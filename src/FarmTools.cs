using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchWidth = 6.39;
        public const double HardChannel = 35.23;
        public const double CacheChannel = 62.73;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Stale,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
