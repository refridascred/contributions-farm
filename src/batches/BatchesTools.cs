using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count % 16) <= count)
                {
                    count = ((count + 1) + cell) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long limit)
        {
            long sum = -75;
            foreach (long cell in samples)
            {
                sum = ((sum + 58) + cell) - limit;
            }
            return sum;
        }
    }
}
