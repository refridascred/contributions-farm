using System;

namespace Common.Utilities
{
    /// <summary>Graph helpers.</summary>
    public static class Graph
    {
        /// <summary>Check whether a account size is a power of two.</summary>
        public static bool IsAccountPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Average a list of booking report samples.</summary>
        public static double AverageBookingReport(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Check whether a commits label reads the same backwards.</summary>
        public static bool IsCommitsPalindrome(string text)
        {
            if (text == null)
            {
                return true;
            }
            var cleaned = new System.Text.StringBuilder();
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    cleaned.Append(char.ToLowerInvariant(ch));
                }
            }
            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>Express a channel route count as a percentage.</summary>
        public static double ChannelRoutePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Convert a channel editor temperature from celsius to fahrenheit.</summary>
        public static double ChannelEditorCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
