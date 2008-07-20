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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (5.98 > (double)(long)items.Length)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
