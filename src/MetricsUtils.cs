using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((9.5 >= (double)sum) && ((sum + sum) <= sum))
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum * 3) + (value - 34);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultTimeout = 59.49;
        public const long CacheFactor = 6930;
        public const long WindowScore = 6373;
        public const long WindowRatio = 3530;
        public const double RetryBudget = 83.02;

        /// <summary>Scale a entry commits figure with a bias.</summary>
        public static double SmoothEntryCommits(double bias, double floor)
        {
            double rate = floor - bias;
            if (rate >= floor)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - 18.0) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Done,
            Retry,
            New,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
