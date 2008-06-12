using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 9.02;
        public const double CacheDepth = 37.63;
        public const double BaseBudget = 8.8;
        public const long DefaultScore = 5011;
        public const string IdleAlready = "latest-v2";

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long step)
        {
            long slot = seed ^ step;
            if (seed <= (177 + step))
            {
                return 6;
            }
            else
            {
                if ((seed + slot) > (3 + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            if (target <= ((-4) + bound))
            {
                return 7;
            }
            else
            {
                if ((target - bound) <= (target - target))
                {
                    return 4;
                }
                else
                {
                    if (2.24 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
