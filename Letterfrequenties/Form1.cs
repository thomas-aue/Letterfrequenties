using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letterfrequenties
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            char a = textBox2.Text[0];

            int count = 0;

            foreach (char c in input)
            {
                if (c == a)
                {
                    count++;
                }
            }
            textBox3.Text = count.ToString();           
        }
    }
}
