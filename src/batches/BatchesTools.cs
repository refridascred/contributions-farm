using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSpan = "strict-1";
        public const string BurstFactor = "alpha";
        public const long MinWindow = 4054;
        public const long CacheLevel = 5319;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Pending,
            Queued,
            Paused,
        }
    }
}
