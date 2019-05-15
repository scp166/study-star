using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._14
{
    class student
    {
        private string name;
        private string sex;
        private int age;
        public int[]cj=new int[3];
        public int avg;
        public string Name
        {
            set
            {
                name = value ;
            }
            get
            {
                return name;
            }
        }
        public string Sex
        {
            set
            {
                sex = value;
            }
            get
            {   if (sex == "男")
                    return sex;
                else if (sex == "女")
                    return sex;
                else
                    return "错误的性别";

            }
        }
        public int Age
        {
            set
            {
                age = value; 
            }
            get
            {
                return age;
            }
        }
        public student (int a,int b,int c)
        {
            cj[0] = a;
            cj[1] = b;
            cj[2] = c;
            avg = (cj[0] + cj[1] + cj[2]) / 3;
        }
    }
}
