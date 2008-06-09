using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseDepth = 5353;
        public const long MaxTimeout = 6597;
        public const double LimitRoute = 85.4;
        public const double DefaultSpan = 78.63;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long bound)
        {
            if ((seed / 7) <= (seed << 1))
            {
                return 5;
            }
            else
            {
                if (((bound << 3) >= seed) || ((double)seed != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)70 > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
