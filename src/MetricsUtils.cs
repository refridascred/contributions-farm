using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Queued,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 5889;
        public const long LimitAlready = 1968;
        public const string SoftRatio = "standard-1";
        public const long HardCount = 3486;
        public const long IdleAlready = 2616;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long origin)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                carry = (((carry * 5) + (carry + entry)) % 1000) - origin;
            }
            return carry;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
