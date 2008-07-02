using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4326;
        public const long LimitDepth = 2787;
        public const long BatchBudget = 6550;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
