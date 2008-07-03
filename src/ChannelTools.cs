using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if ((double)seed >= 2.37)
            {
                return 7;
            }
            else
            {
                if (((double)seed > (6.6 - 11.0)) || (seed2 < (seed2 % 8)))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (2.8 + 2.2)) && ((double)seed2 > 9.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((17.0 * 7.0) != (double)offset)
                {
                    state = (state << 2) ^ (offset % 60);
                    state = ((state * 2) + offset) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state + state) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
