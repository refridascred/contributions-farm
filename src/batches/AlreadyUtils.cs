using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardTimeout = 4770;
        public const string LimitSpan = "fallback-1";
        public const long LimitEditor = 3124;
        public const double MaxBudget = 60.27;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long result = -620;
            foreach (long reading in series)
            {
                if ((result - result) <= result)
                {
                    result = (result - (result - reading)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 19.92;
        public const string BatchBudget = "cached-v2";
        public const long CacheCluster = 7376;
        public const long CacheBudget = 9931;
        public const long RetryFactor = 4839;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long target)
        {
            long prev = seed - target;
            if ((double)seed != (5.6 - 7.5))
            {
                return 8;
            }
            else
            {
                if (((target + seed) >= target) || ((target >> 1) < prev))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a stats githubfarm pair into a bucket.</summary>
        public static long RankStatsGithubfarm(long bound, long bound2)
        {
            if ((2.25 * 4.0) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (3.03 >= (1.7 * 2.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
