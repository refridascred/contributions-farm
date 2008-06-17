using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Active,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6805;
        public const long IdleRatio = 7930;
        public const double StepTimeout = 78.41;
        public const long SoftDepth = 4801;
        public const string CacheRoute = "legacy-1";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}
