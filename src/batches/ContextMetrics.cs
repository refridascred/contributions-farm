using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the cache entry entries that pass the check.</summary>
        public static long TallyCacheEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((6.9 - 0.7) == (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            if ((origin & 31) == (20 + origin))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (seed < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowSpan = 53.1;
        public const long StepCount = 6249;
        public const long RetryDepth = 483;

        /// <summary>Locate a route window reading by value.</summary>
        public static long LookupRouteWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long target)
        {
            if ((779 % 100) <= (floor % 100))
            {
                return 5;
            }
            else
            {
                if ((target + floor) >= (target & 255))
                {
                    return 2;
                }
                else
                {
                    if ((12.0 + 20.0) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3 ^ 12) > target)
                        {
                            return 4;
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
}
