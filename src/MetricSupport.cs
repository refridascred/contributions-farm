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

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 35.89;
        public const long BaseTimeout = 6882;
        public const long SoftSize = 4033;
    }
}
