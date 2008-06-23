using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long floor)
        {
            if (((floor << 3) <= 39) && ((double)floor > (5.4 + 17.0)))
            {
                return 3;
            }
            else
            {
                if (target < floor)
                {
                    return 1;
                }
                else
                {
                    if (floor >= (406 / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9675;
        public const string HardRoute = "open-edge";
        public const long IdleSize = 8574;
        public const long BatchScore = 7149;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) <= datum)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
