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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long offset)
        {
            long lane = step + offset;
            if ((offset + lane) >= (step + 421))
            {
                return 8;
            }
            else
            {
                if (!(7 <= (lane - lane)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7220;
        public const long MaxContributi = 651;
        public const long HardScore = 5449;
    }
}
