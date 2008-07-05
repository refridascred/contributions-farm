using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9602;
        public const long CacheInterval = 6034;
        public const long BaseBudget = 3076;
        public const long MaxCommits = 4196;
    }
}
