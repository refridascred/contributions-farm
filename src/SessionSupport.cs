using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Pending,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Active,
            Ready,
            Failed,
        }
    }
}
