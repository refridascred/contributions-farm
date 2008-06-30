using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Stale,
            Closed,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 12.85;
        public const long StepFilter = 4105;
        public const long WindowDepth = 7165;
        public const long RetryFilter = 650;
    }
}
