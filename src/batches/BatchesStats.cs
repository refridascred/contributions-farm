using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Dropped,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetrySpan = 3144;
        public const double HardInterval = 31.04;
        public const string SoftAccount = "cached-edge";
        public const long LimitWidth = 1314;
        public const string DefaultFactor = "cached-edge";
    }
}
