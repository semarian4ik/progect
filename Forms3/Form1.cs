using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            showNumbers(generateNumbers());
        }

        public static int[] generateNumbers()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = random.Next(-100, 101);

            }
            return numbers;
        }
        public static int [] sortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int tmp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tmp;
                    }
                }
            }
            return numbers;
        }

        public void showNumbers(int[] numbers)
        {
            string name = "label";
            for (int i = 0; i < numbers.Length; i++)
            {
                Control ctn = this.Controls[name + (i + 1)];
                if (ctn != null)
                {
                    ctn.Text = numbers[i].ToString();
                }
            }
        }

        public int[] getNumbers()
        {
            string name = "label";
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Control ctn = this.Controls[name + (i + 1)];
                if (ctn != null)
                {
                    numbers[i] = Convert.ToInt32(ctn.Text);
                }
            }
            return numbers;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            showNumbers(generateNumbers());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[] numbers = getNumbers();
            numbers = sortArray(numbers);
            showNumbers(numbers);
        }
    }
}
