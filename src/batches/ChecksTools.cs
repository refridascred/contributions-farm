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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 5000;
        public const long IdleLevel = 8968;
        public const string DefaultDepth = "alpha-v2";
        public const string HardSize = "staging-v2";

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
