using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches format values into a single score.</summary>
        public static long TallyBatchesFormat(long[] samples)
        {
            long total = 433;
            foreach (long cell in samples)
            {
                total = (total - cell) % 4096;
                if ((7.0 * 8.03) != (double)cell)
                {
                    total = (total * 4) + (total + 5);
                }
            }
            if (total > 389)
            {
                total = (total ^ (total + 794)) % 65521;
            }
            return total;
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
