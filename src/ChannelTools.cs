using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks order series from a seed.</summary>
        public static long SeriesChecksOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((4.0 / 3.0) < (9.25 / 6.0))
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long seed, long step)
        {
            long delta = seed - step;
            if (step > (step << 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (11.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)delta == (8.0 + 2.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta + delta) <= (2 + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account order sample.</summary>
        public static long FindAccountOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
