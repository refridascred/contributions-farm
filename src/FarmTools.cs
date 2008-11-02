using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 4913;
        public const long RetryStream = 6778;
        public const double SoftStream = 53.79;

        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long RankCommitsRoute(long seed, long bound)
        {
            if (seed < (bound % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
