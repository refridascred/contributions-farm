using System;

namespace Common.Utilities
{
    /// <summary>Token helpers.</summary>
    public static class Token
    {
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

        /// <summary>Sum the squares of channel samples.</summary>
        public static double ChannelEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Convert a cursor temperature from celsius to fahrenheit.</summary>
        public static double CursorCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Express a token count as a percentage.</summary>
        public static double TokenPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Interpolate between two graph values.</summary>
        public static double LerpGraph(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Express a route count as a percentage.</summary>
        public static double RoutePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
