using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 1848;
        public const double BurstReport = 51.71;
        public const string WindowReport = "legacy-edge";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Dropped,
            Failed,
            Queued,
        }
    }
}
