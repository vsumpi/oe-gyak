namespace euklidesz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az egyik számot.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a másik számot.");
            int b = Convert.ToInt32(Console.ReadLine());
            int r;

            Console.WriteLine($"Keressük meg {a} és {b} legnagyobb közös osztóját!");

            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine($"A legnagyobb közös osztó: {a}");
            Console.ReadKey();
        }
    }
}