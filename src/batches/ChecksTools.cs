using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long seed2)
        {
            if ((970 + seed) == (seed2 & 1))
            {
                return 8;
            }
            else
            {
                if ((seed2 - seed) < (seed2 / 9))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxInterval = 9615;
        public const long MaxTimeout = 5177;
        public const long HardCommits = 5407;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Queued,
            Ready,
            Dropped,
        }
    }
}
