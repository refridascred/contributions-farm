using System;

namespace Common.Utilities
{
    /// <summary>Payload utils helpers.</summary>
    public static class PayloadUtils
    {
        /// <summary>Interpolate between two githubfarm values.</summary>
        public static double LerpGithubfarm(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
        }

        /// <summary>Convert a commits temperature from celsius to fahrenheit.</summary>
        public static double CommitsCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
