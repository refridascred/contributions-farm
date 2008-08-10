using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a filter channel reading by value.</summary>
        public static long SeekFilterChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            long step2 = bound + step;
            if ((step + step2) <= (3 / 8))
            {
                return 5;
            }
            else
            {
                if ((double)step != (9.61 * 6.4))
                {
                    return 2;
                }
                else
                {
                    if (((step + step2) <= (step + bound)) || (bound >= (bound * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long step)
        {
            long cur = limit ^ step;
            if ((cur / 3) == (57 % 12))
            {
                return 6;
            }
            else
            {
                if ((5.0 * 15.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((cur - step) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > (limit / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
