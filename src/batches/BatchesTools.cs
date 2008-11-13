using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up batch graph samples.</summary>
        public static long MatchBatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score - score) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((((mix << 2) ^ 0) % 1000) - cell) - target;
            }
            return mix;
        }
    }
}
