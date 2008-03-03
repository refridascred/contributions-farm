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

        /// <summary>Iterate the batches stats series from a seed.</summary>
        public static long DeriveBatchesStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 527;
        public const long SoftReport = 2984;
        public const long CacheReport = 9599;
    }
}
