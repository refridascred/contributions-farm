using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long AuditCommitsSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(((cell + 3) == ((-738) - (long)levels.Length)) || (cell <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultTimeout = 59.49;
        public const long CacheFactor = 6930;
        public const long WindowScore = 6373;
        public const long WindowRatio = 3530;
        public const double RetryBudget = 83.02;

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long AuditStreamFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >> 4) < (5 & 63))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mix = -844;
            foreach (long item in samples)
            {
                if (!(323 < mix))
                {
                    mix = ((mix * 4) + 5) - item;
                }
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
