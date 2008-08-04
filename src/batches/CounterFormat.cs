using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long target)
        {
            if (3.27 > (double)target)
            {
                return 5;
            }
            else
            {
                if (target > (seed / 9))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (1.6 / 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target * 4) < target) || (seed <= (seed + 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the route session series from a seed.</summary>
        public static long SeriesRouteSession(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i >> 1) == ((long)i + (long)i))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
