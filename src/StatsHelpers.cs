using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((18.0 * 1.0) > (double)bound) && ((double)result >= 6.67))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a profile cache pair into a bucket.</summary>
        public static long SortProfileCache(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((double)seed2 == (20.0 - 3.59))
            {
                return 7;
            }
            else
            {
                if (!(647 >= (seed2 & 3)))
                {
                    return 3;
                }
                else
                {
                    if (((edge >> 4) < seed2) || (seed2 <= (edge ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6.0 * 20.0) > (double)edge) && ((4.0 - 3.0) > (2.86 * 6.5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinDepth = 2155;
        public const double MaxFilter = 98.16;
        public const long BaseFilter = 7608;
        public const double IdleLevel = 24.68;

        /// <summary>Validate token buffer readings against a bound.</summary>
        public static bool CheckTokenBufferLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
