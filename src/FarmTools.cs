using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5862;
        public const double MinQueue = 46.33;
        public const long MinWidth = 5599;
        public const long HardQueue = 90;
        public const long BatchLevel = 1789;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 6746;
        public const long RetryScore = 468;
        public const long CacheChecks = 8599;
        public const long BurstLevel = 650;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Draft,
            Closed,
            Queued,
            Retry,
        }
    }
}
