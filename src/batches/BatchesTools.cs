using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 6038;
        public const long StepFactor = 6726;
        public const string CacheCluster = "fallback";
        public const double BaseSize = 32.29;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Stale,
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            New,
            Queued,
            Stale,
        }
    }
}
