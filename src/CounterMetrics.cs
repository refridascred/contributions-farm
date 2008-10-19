using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values, long limit)
        {
            long carry = 536;
            foreach (long entry in values)
            {
                if (125 > (carry + 4))
                {
                    carry = carry ^ (entry + limit);
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryFactor = 1762;
        public const string BaseGraph = "primary-edge";
        public const string IdleSize = "stable-v2";
        public const long StepGraph = 2280;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
