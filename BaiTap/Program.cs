using System;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            // bài 1: Viết chương trình màn hình console sẽ cho phép ta nhập vào một số nguyên, in ra màn hình “Đây là số nguyên dương”
            //Nếu số vừa nhập vào là một số lớn hơn hoặc bằng 0, ngược lại in ra “Đây là số nguyên âm”.
            Console.Write("Nhap vao so number: ");
            int Number_317 = Convert.ToInt32(Console.ReadLine());
            if (Number_317 > 0)
            {
                Console.WriteLine("Đây là so nguyên dương");
            }
            else
            {
                Console.WriteLine("Đây là so nguyên âm");
            }


            /* bài 2: Viết chương trình cho phép nhập vào một số nguyên dạng số, sau khi chạy thì chương trình sẽ ghi số đó ra dưới dạng chữ.
             VD: 1->Một, 2->Hai, …*/

                
                Console.WriteLine("Nhap vao mot so nguyen:");
                int  n_317 = int.Parse(Console.ReadLine());

                switch (n_317)
                {
                    case 0: Console.WriteLine("Không"); break;
                    case 1: Console.WriteLine("Mot"); break;
                    case 2: Console.WriteLine("Hai"); break;
                    case 3: Console.WriteLine("Ba"); break;
                    case 4: Console.WriteLine("Bon"); break;
                    case 5: Console.WriteLine("Nam"); break;
                    case 6: Console.WriteLine("Sau"); break;
                    case 7: Console.WriteLine("Bay"); break;
                    case 8: Console.WriteLine("Tam"); break;
                    case 9: Console.WriteLine("Chin"); break;
                    default:
                    Console.WriteLine("Chỉ có 0 - 9 thôi :D");
                        break;
                }

            /* bài 3: Viết chương trình cho phép nhập vào 3 số thực
                Chương trình này sẽ kiểm tra 3 số này có phải là 3 cạnh của một tam giác hay không.*/
            Console.Write("Nhap vao canh a:");
            float a_317 = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh b:");
            float b_317 = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh c:");
            float c_317 = float.Parse(Console.ReadLine());

            if (a_317 + b_317 < c_317 || a_317 + c_317 < b_317 || b_317 + c_317 < a_317)
            { 
                Console.WriteLine("day khong phai la tam giac ");
            }
         
            else
            {
                Console.WriteLine("la  tam giác");
            }

            /*Viết chương trình cho phép nhập vào 3 số
            Chương trình sẽ kiểm tra 3 số này có phải là 3 cạnh của một tam giác vuông hay không.*/

            Console.Write("Nhap vao canh 1:");
            float c1_317 = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh 2:");
            float c2_317 = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh 3:");
            float c3_317 = float.Parse(Console.ReadLine());

            if (c1_317 *c1_317 == c2_317*c2_317 + c3_317*c3_317 || c2_317 * c2_317 == c1_317 * c1_317 + c3_317 * c3_317 || c3_317 * c3_317 == c2_317 * c2_317 + c1_317 * c1_317)
            {
                Console.WriteLine("la tam giac vuong ");
            }

            else
            {
                Console.WriteLine("khong phai la tam giac vuong");
            }
        }

    }
}
