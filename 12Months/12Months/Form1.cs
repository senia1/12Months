using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12Months
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//comment
            show_month_picture();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e) 
        {
            show_month_picture();
        }

        private void show_month_picture()
        {
            string month;
            month = monthCalendar.SelectionStart.Month.ToString();
            try
            {
                pictureBox.Image = Image.FromFile("months\\" + month + ".jpg");
            }
            catch { MessageBox.Show("Файлы с картинками не найдены!"); }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = !monthCalendar.Visible;
        }
    }
}
