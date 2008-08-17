using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitLevel = 3922;
        public const long BurstScore = 3584;
        public const long WindowSize = 1386;
        public const long WindowDepth = 8374;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
