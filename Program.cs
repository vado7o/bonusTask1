// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

Console.Clear();
Console.WriteLine("Задача со звёздочкой: программа, выдающая максимальную цифру округлённой площади круга");
double square = 0;
int number = 0;

while(true) {
Console.WriteLine("Введите радиус круга:\n");
if(int.TryParse(Console.ReadLine(), out number)) {
    double digitOut = Convert.ToDouble(number);
    square = Math.Round(Math.PI * digitOut * digitOut, 0);
    if(number > 0) {
        break;
    } else Console.WriteLine("Значение радиуса не может быть отрицательным!\n");
}  else Console.WriteLine("Некорректно введено значение радиуса!\n");
}
int maxDigit = 0;
char[] charArray = square.ToString().ToCharArray();
for(int i = 0; i <= charArray.Length - 1; i++) {
    int charToDigit = int.Parse(charArray[i].ToString());
    if(charToDigit > maxDigit) maxDigit = charToDigit;
}

Console.WriteLine("\nПлощадь круга с радиусом " + number + " равна " + square);
Console.WriteLine("\nМаксимальная цифра данного значения: " + maxDigit);