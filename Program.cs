// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct sinhvien
        {
            public string hoten114;
            public string msv114;
            public gioitinh gioitinh114;
            public double toan114;
            public double ly114;
            public double hoa114;


        };
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n114 = int.Parse(Console.ReadLine());
            sinhvien[] sv114 = new sinhvien[n114];
            nhapDS(ref sv114, n114);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv114, n114);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht114 = Console.ReadLine();
            timKiem(sv114, n114, ht114);

            Console.ReadLine();
        }

        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht114 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv114 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt114 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt114 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl114 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh114 = double.Parse(Console.ReadLine());


                sv[i].hoten114 = ht114;
                sv[i].msv114 = msv114;
                if (gt114 == 0)
                    sv[i].gioitinh114 = gioitinh.Nam;
                else
                    sv[i].gioitinh114 = gioitinh.Nu;
                sv[i].toan114 = dt114;
                sv[i].ly114 = dl114;
                sv[i].hoa114 = dh114;

            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach (sinhvien item114 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item114.hoten114);
                Console.WriteLine("Ma sinh vien: " + item114.msv114);
                int gt = (int)item114.gioitinh114;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nu");
                Console.WriteLine("Diem toan: " + item114.toan114);
                Console.WriteLine("Diem ly: " + item114.ly114);
                Console.WriteLine("Diem hoa: " + item114.hoa114);
                int hocluc = (int)diemTB(item114.toan114, item114.ly114, item114.hoa114);
                switch (hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc: Gioi");
                        break;

                }

                i++;
            }
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item117 in sv)
            {
                if (item117.hoten114 == ht)
                {
                    Console.WriteLine("Ho ten: " + item117.hoten114);
                    Console.WriteLine("Ma sinh vien: " + item117.msv114);
                    int gt = (int)item117.gioitinh114;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nu");
                    Console.WriteLine("Diem toan: " + item117.toan114);
                    Console.WriteLine("Diem ly: " + item117.ly114);
                    Console.WriteLine("Diem hoa: " + item117.hoa114);
                    int hocluc = (int)diemTB(item117.toan114, item117.ly114, item117.hoa114);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
    }
}
