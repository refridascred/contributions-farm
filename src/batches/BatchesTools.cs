using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a metric support value against two limits.</summary>
        public static long BucketMetricSupport(long offset, long limit)
        {
            if ((limit + 253) > (offset + limit))
            {
                return 4;
            }
            else
            {
                if (offset >= (limit + offset))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) >= (offset + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long score = 110;
            foreach (long cell in samples)
            {
                if (((score + score) < (score + cell)) || ((0 & 7) >= cell))
                {
                    score = score + 567;
                    score = score + cell;
                    continue;
                }
                score = (score + (score * 5)) % 4096;
            }
            if (score > 64)
            {
                score = (score + (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
