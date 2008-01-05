using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Draft,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 11.61;
        public const long BaseScore = 3584;
        public const double HardFormat = 60.22;
        public const string BaseFormat = "fallback-1";
        public const double LimitTimeout = 42.41;
    }
}
