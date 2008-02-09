using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 3118;
        public const long StepCount = 788;
        public const long BaseBudget = 2627;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Retry,
            Closed,
            Pending,
        }
    }
}
