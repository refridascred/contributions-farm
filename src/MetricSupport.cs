using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheWidth = 71.68;
        public const long BurstOrder = 5053;
        public const string StepRatio = "staging";
        public const long StepOrder = 9076;
        public const string HardWidth = "staging-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 8462;
        public const long BaseRatio = 5800;
        public const long CacheCommand = 3573;
    }
}
