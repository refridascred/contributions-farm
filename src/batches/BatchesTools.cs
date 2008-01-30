using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Synced,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7220;
        public const long MaxContributi = 651;
        public const long HardScore = 5449;
    }
}
