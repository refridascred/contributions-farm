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

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 3416;
        public const string HardStream = "stable-1";
        public const long WindowBudget = 7950;
        public const long CacheInterval = 1944;
    }
}
