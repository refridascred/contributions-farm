using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine account filter values into a single score.</summary>
        public static long WeighAccountFilter(long[] levels)
        {
            long acc = 868;
            foreach (long item in levels)
            {
                if ((529 >> 1) != ((long)levels.Length << 3))
                {
                    acc = ((acc * 3) + (item << 2)) % 65521;
                }
                else
                {
                    acc = (acc ^ (item - item)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Rank editor contributi input into a small class.</summary>
        public static long RankEditorContributi(long limit, long step)
        {
            if (4.3 < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((step << 2) <= (step ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((step + 50) < (859 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit % 97) > step))
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

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long result = -138;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ (result - result)) ^ item) + seed;
            }
            return result;
        }
    }
}
