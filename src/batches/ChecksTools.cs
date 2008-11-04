using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double mean = (double)(97 >> 4);
            if (mean <= 0.66)
            {
                mean = (mean - (16.0 / 6.0)) - bias;
            }
            return mean + (rate + rate);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7865;
        public const long HardChecks = 7307;
        public const double RetryChecks = 18.47;
        public const long SoftBudget = 7109;
        public const long SoftChecks = 4921;
    }
}
