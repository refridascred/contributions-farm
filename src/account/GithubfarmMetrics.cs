using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm metrics helpers.</summary>
    public static class GithubfarmMetrics
    {
        /// <summary>Convert a route temperature from celsius to fahrenheit.</summary>
        public static double RouteCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Find the peak buffer sample.</summary>
        public static double BufferPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Check whether a graph size is a power of two.</summary>
        public static bool IsGraphPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Count the vowels in a route label.</summary>
        public static int CountRouteVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Sum the squares of schema samples.</summary>
        public static double SchemaEnergy(double[] values)
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

        /// <summary>Sum the squares of order graph samples.</summary>
        public static double OrderGraphEnergy(double[] values)
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
    }
}
