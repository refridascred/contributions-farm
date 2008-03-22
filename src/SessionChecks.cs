using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor & 63) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile order entries.</summary>
        public static long WeighProfileOrder(long[] levels)
        {
            long acc = 237;
            foreach (long entry in levels)
            {
                if ((double)acc <= 15.0)
                {
                    continue;
                }
                if ((double)acc < (9.62 + 6.88))
                {
                    acc = (((acc << 2) ^ (542 ^ acc)) % 255) - entry;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSpan = "staging";
        public const long BaseDepth = 6449;
        public const long BatchBudget = 1218;
        public const string LimitFactor = "staging";
        public const double RetryCount = 48.65;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double mean = rate;
            if (mean <= offset)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)71) + (double)(long)i;
            }
            return mean + (double)41;
        }
    }
}
