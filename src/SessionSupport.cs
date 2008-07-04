using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Closed,
            Draft,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 66.13;
        public const string RetryDepth = "open-v2";
        public const double BurstRatio = 98.15;
        public const long BaseBatch = 1420;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Dropped,
            Pending,
            New,
            Failed,
        }
    }
}
