using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Queued,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}
