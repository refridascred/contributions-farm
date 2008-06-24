using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
