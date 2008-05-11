using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double AdjustReportBatches(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= 2.4)
            {
                bias2 = bias2 + (bias * 5.17);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)(-26)) + (double)(long)i;
            }
            return bias2 - (double)6;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state << 3) ^ state;
                if (((long)i << 1) >= (offset & 15))
                {
                    state = ((state << 3) ^ (state / 6)) % 1000;
                    state = state - (state * 4);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}
