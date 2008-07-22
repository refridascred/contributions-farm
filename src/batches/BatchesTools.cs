using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values)
        {
            long sum = -37;
            foreach (long item in values)
            {
                if (((sum * 3) >= (item / 5)) && ((double)item > (7.58 + 3.72)))
                {
                    sum = (sum - (item ^ (long)values.Length)) % 1000;
                }
                sum = (sum - item) % 65521;
                if (((double)item <= (1.3 + 1.0)) || (sum <= item))
                {
                    sum = ((sum * 5) + (sum >> 5)) % 101;
                }
            }
            if (sum < 37)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)matches >= (8.0 / 4.0)) || !(((long)levels.Length % 5) <= datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
