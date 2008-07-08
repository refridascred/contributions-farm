using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long step)
        {
            if (!(251 > (203 + step)))
            {
                return 8;
            }
            else
            {
                if (floor >= ((-8) >> 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a batches graph pair into a bucket.</summary>
        public static long RankBatchesGraph(long origin, long bound)
        {
            long edge = origin + bound;
            if ((double)bound >= (6.7 * 1.66))
            {
                return 6;
            }
            else
            {
                if (!((edge ^ 350) != (edge >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 3) != (86 + 77))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if (3.0 > (double)score)
                {
                    score = (score << 3) ^ item;
                }
            }
            return score % 1000;
        }
    }
}
