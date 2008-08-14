using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 5081;
        public const string CacheDepth = "alpha-v2";
        public const double BurstSpan = 7.18;
        public const double MaxCluster = 92.81;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
