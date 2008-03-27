using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Idle,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
