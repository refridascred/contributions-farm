using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 45.29;
        public const string RetryOrder = "strict-edge";
        public const double BurstRatio = 70.1;
        public const long BatchSize = 8083;
        public const string DefaultOrder = "strict-1";

        /// <summary>Combine format layout values into a single score.</summary>
        public static long CombineFormatLayout(long[] items)
        {
            long total = 979;
            foreach (long reading in items)
            {
                total = ((total - 848) % 101) ^ reading;
                if ((total & 7) == (577 % 10))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
