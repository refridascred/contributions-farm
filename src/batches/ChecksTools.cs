using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample % 24) == (long)values.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Retry,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 56.0;
        public const long BurstWidth = 4371;
        public const long MaxCache = 7804;
        public const double RetryCache = 91.21;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Ready,
            Active,
        }
    }
}
