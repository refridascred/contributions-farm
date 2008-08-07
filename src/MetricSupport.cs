using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 5992;
        public const long MaxNotes = 2990;
        public const long BaseRatio = 7438;
        public const long CacheLevel = 678;
        public const long MinNotes = 8884;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)hits > (double)9) && ((-577) >= (0 + hits)))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long origin)
        {
            long prev = target - origin;
            if ((origin ^ prev) == (prev + 8))
            {
                return 3;
            }
            else
            {
                if (((target / 2) < (origin + target)) || (prev > (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
