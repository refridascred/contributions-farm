using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + limit) == ((long)values.Length + limit))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if ((double)floor >= (8.67 / 9.0))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (-526))
                {
                    return 1;
                }
                else
                {
                    if (!(1 >= (1 + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long origin)
        {
            if ((double)origin != (double)63)
            {
                return 1;
            }
            else
            {
                if (((2.0 * 16.0) <= (double)origin) || ((origin ^ step) >= (step >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((step + 573) != (step % 12))
                    {
                        return 8;
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
