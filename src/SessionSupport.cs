using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Queued,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
