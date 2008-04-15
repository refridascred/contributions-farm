using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 4194;
        public const long RetryAccount = 8480;
        public const double MinBudget = 0.53;
    }
}
