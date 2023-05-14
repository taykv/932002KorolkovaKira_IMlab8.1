using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8yesno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double p = 0.6;
        double a;
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {	
			a = r.NextDouble();
            label3.Text = "Ответ:";
            if (a <= p) label2.Text = "Да"; 
            else label2.Text = "Нет";

			if (textBox1.Text == "")
			{
				label3.Text = "А на что отвечать?...";
				label2.Text = "";
			}
		}
    }  
}
