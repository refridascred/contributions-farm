using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 3118;
        public const long BurstDepth = 9433;
        public const string IdleRatio = "cached-1";
        public const long DefaultEditor = 185;
        public const long IdleEditor = 8003;

        /// <summary>Grade a format githubfarm value against two limits.</summary>
        public static long RankFormatGithubfarm(long seed, long origin)
        {
            long edge = seed - origin;
            if (((4 + origin) <= ((-2) / 4)) && ((double)0 > (double)edge))
            {
                return 1;
            }
            else
            {
                if (!((8 - edge) < (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + 0) == (edge >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryCount = 5664;
        public const double RetryGithubfarm = 77.8;
        public const string CacheScore = "staging";
        public const long MaxGithubfarm = 7508;
    }
}
