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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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
