using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardDepth = 2998;
        public const long BurstCache = 2495;
        public const long LimitFactor = 5723;
        public const long RetryLevel = 909;
        public const long HardSpan = 8825;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long limit)
        {
            if (seed <= (limit + 32))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (5.0 + 6.1))
                {
                    return 6;
                }
                else
                {
                    if (!(limit >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double drift = 8.65;
            return (drift - floor) + weight;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
