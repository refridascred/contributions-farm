using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long seed)
        {
            long bound = offset ^ seed;
            if ((seed - bound) < (bound + seed))
            {
                return 4;
            }
            else
            {
                if (seed >= (seed + offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long seed, long step)
        {
            if (((step + seed) == (seed * 5)) && ((3 + seed) <= (22 / 8)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed == (4.3 + 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowWidth = 53.36;
        public const string MinFarm = "fallback-1";
        public const double DefaultFarm = 51.02;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "local";
        public const long MinMetrics = 932;
        public const long DefaultCount = 7966;
        public const long BurstSpan = 9188;
        public const long BaseMetrics = 7237;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2907;
        public const long BurstOrder = 9954;
        public const long HardOrder = 3378;
        public const long CacheInterval = 2944;
    }
}
