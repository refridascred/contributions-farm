using System;

namespace Common.Utilities
{
    /// <summary>Context utils helpers.</summary>
    public static class ContextUtils
    {
        /// <summary>Convert a digest temperature from celsius to fahrenheit.</summary>
        public static double DigestCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Convert a graph temperature from celsius to fahrenheit.</summary>
        public static double GraphCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Interpolate between two folder values.</summary>
        public static double LerpFolder(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}
