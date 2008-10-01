using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 2715;
        public const long StepRoute = 2629;
        public const long CacheLevel = 8461;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "fallback-edge";
        public const string MinCount = "standard-edge";
        public const string RetryLevel = "local-edge";
        public const string BurstCommand = "local-1";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
