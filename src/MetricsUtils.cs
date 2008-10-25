using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const long CacheInterval = 2943;
        public const long MinMetric = 4344;
        public const long HardSize = 1459;
        public const double IdleTimeout = 9.85;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 3714;
        public const long CacheBatch = 662;
        public const long RetryLevel = 9653;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Stale,
            Idle,
            Closed,
        }
    }
}
