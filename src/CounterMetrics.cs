using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long total = -6;
            foreach (long item in samples)
            {
                if (total > item)
                {
                    total = ((total * 2) + (total + item)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long AuditSupportMetricOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((step + matches) >= (1 / 6))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3004;
        public const long MaxFilter = 9734;
        public const long DefaultFactor = 9677;
        public const double BurstDepth = 97.0;
        public const string CacheLevel = "legacy";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry < ((-421) & 63)) && ((matches + matches) >= entry)) && ((entry + matches) == (matches / 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
