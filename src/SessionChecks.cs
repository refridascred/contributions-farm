using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Queued,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((1.0 * 11.0) < (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell / 9) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
