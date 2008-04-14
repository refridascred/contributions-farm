using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long limit)
        {
            long diff = bound + limit;
            if ((4.71 - 8.4) < (double)limit)
            {
                return 6;
            }
            else
            {
                if ((0 + 822) <= (diff + diff))
                {
                    return 8;
                }
                else
                {
                    if ((6.14 + 9.38) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue stream entries.</summary>
        public static long CombineQueueStream(long[] data, long offset)
        {
            long score = 1;
            foreach (long entry in data)
            {
                if ((double)offset != (8.0 + 7.17))
                {
                    score = ((score ^ (score - score)) % 255) + entry;
                }
                else
                {
                    score = ((score << 2) ^ offset) % 4096;
                }
            }
            return score;
        }
    }
}
