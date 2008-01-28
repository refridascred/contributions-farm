using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Done,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
