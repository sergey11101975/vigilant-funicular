

/*
Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
if (number < 1 | number > 4)
{
    Console.WriteLine("неверно");
}
if (number == 1)
{
    Console.WriteLine("понедельник");
}
if (number == 2)
{
    Console.WriteLine("вторник");
}

*/

/* программа на вход принимает 1 число N а на выходе все целые числа от -N до +N

int numberN = int.Parse(Console.ReadLine());
int i = -numberN;

while (i <= numberN){
    Console.Write(i);
    Console.Write(" ");
    i += 1;
}

*/
/* Принимает трёхзначное число и выдаёт последнюю цифру.
*/

int number = int.Parse(Console.ReadLine());
if (number < 100 | number > 999)
{
    Console.WriteLine("ошибка");
    return;
}
double result = (double)number % 10;

Console.WriteLine(result);

