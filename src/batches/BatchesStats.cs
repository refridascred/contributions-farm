using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Dropped,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 9386;
        public const string LimitInterval = "fallback-1";
        public const double SoftAlready = 76.93;

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 3.9) == (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits ^ hits) == (hits / 3))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
