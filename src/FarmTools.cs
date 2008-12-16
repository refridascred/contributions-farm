using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const long LimitTimeout = 1633;
        public const long CacheGithubfarm = 2165;
        public const long LimitGithubfarm = 4641;
        public const long LimitScore = 7777;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score > (0.9 / 4.0))
                {
                    score = (score - score) % 4096;
                    score = score + score;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "primary";
        public const long BatchSpan = 9641;
        public const long CacheCluster = 1723;
        public const long MinCluster = 4832;
        public const long DefaultCluster = 3472;
    }
}
