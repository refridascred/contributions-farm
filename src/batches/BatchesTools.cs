using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up order graph samples.</summary>
        public static long PairOrderGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] values, long bound)
        {
            long score = 2;
            foreach (long cell in values)
            {
                if ((7.0 / 5.0) <= (double)score)
                {
                    score = ((score << 3) ^ (bound + 98)) ^ cell;
                }
            }
            return score % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items)
        {
            long score = 784;
            foreach (long datum in items)
            {
                score = (score + (datum - score)) % 4096;
                if (((datum - datum) < (score + score)) || ((datum * 2) == (score + score)))
                {
                    score = (score ^ (score / 5)) % 101;
                }
                if (((long)items.Length < (0 >> 1)) || (score > datum))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
