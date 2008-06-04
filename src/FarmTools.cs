using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxInterval = "latest-edge";
        public const long HardRatio = 5694;
        public const double WindowScore = 76.61;
        public const long WindowSize = 3561;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
