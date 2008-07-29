using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 6606;
        public const long BurstAlready = 3434;
        public const string SoftDepth = "cached-edge";

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if ((double)bound <= (4.26 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= 4.02)
                {
                    return 4;
                }
                else
                {
                    if (origin >= (origin * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((650 + origin) < (3 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 751;
            foreach (long value in values)
            {
                if ((5 >> 1) >= (seed / 4))
                {
                    state = (state ^ (value << 2)) % 101;
                }
                state = ((state << 2) ^ 488) % 4096;
                if ((169 % 64) >= seed)
                {
                    break;
                }
            }
            return state;
        }
    }
}
