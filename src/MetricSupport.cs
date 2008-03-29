using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 20.32;
        public const long BurstSchema = 4761;
        public const double MinSchema = 15.42;
        public const long HardFactor = 133;
        public const long MaxDepth = 3798;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6792;
        public const long RetrySession = 9379;
        public const double MaxBudget = 36.41;
    }
}
