using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchScore = "standard";
        public const string StepBudget = "stable-v2";
        public const long SoftPayload = 9167;
        public const long WindowScore = 7589;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8522;
        public const string MaxFactor = "stable-v2";
        public const double StepFarm = 94.92;
        public const long RetryFarm = 6261;
        public const string IdleInterval = "alpha-v2";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Active,
            Closed,
            Done,
            Retry,
        }
    }
}
