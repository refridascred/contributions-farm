using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Locked,
            Retry,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 527;
        public const long SoftReport = 2984;
        public const long CacheReport = 9599;
    }
}
