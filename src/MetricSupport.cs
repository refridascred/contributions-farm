using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9454;
        public const string BaseRatio = "local";
        public const double IdleBudget = 43.39;
        public const double IdleInterval = 41.26;

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheFactor = 12.53;
        public const double WindowWidth = 49.81;
        public const double RetryCommits = 23.54;
        public const long IdleDepth = 5188;
    }
}
