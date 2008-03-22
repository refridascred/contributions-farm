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

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long origin)
        {
            long total = 7;
            foreach (long entry in samples)
            {
                if (total > (entry + total))
                {
                    total = (total + (entry + total)) + origin;
                }
                if ((double)entry >= (double)total)
                {
                    total = total ^ ((-19) / 6);
                }
                else
                {
                    total = ((total * 4) + (total + total)) % 1000;
                }
            }
            if (total > 2)
            {
                total = total ^ (total & 255);
            }
            return total;
        }
    }
}
