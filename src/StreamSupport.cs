using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 91.95;
        public const long BatchRatio = 1561;
        public const double RetryChecks = 58.53;
        public const string CacheChecks = "stable";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Failed,
            Queued,
            Active,
        }
    }
}
