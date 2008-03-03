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

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 58;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ (1 / 2)) % 101) + datum;
            }
            if (mix > 3)
            {
                mix = (mix << 2) ^ (mix ^ 8);
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 527;
        public const long SoftReport = 2984;
        public const long CacheReport = 9599;
    }
}
