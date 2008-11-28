using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5693;
        public const double MinInterval = 80.86;
        public const long MaxWidth = 5583;
        public const long StepRatio = 197;

        /// <summary>Roll a route report counter forward.</summary>
        public static long StepRouteReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
