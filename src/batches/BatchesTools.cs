using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples, long limit)
        {
            long acc = 95;
            foreach (long item in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc ^ (48 + item)) % 4096) + (long)i) + limit;
                }
                acc = acc - acc;
            }
            if (acc < 810)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long BucketReportCommits(long limit, long origin)
        {
            long edge = limit - origin;
            if (!((edge * 4) < limit))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) > (83 / 5))
                {
                    return 1;
                }
                else
                {
                    if (limit < (origin - edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit >= (6.2 / 2.0)) || (552 >= origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
