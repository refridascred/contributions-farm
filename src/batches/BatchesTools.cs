using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches route samples are out of range.</summary>
        public static long CountBatchesRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)count > (6.34 - 15.0)) || ((datum & 7) == (83 * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long offset)
        {
            long score = 1;
            foreach (long entry in values)
            {
                score = score - (entry - 863);
                if (((score << 3) <= (22 + offset)) || ((entry % 5) > (score - offset)))
                {
                    score = score - (score + offset);
                }
            }
            return score;
        }
    }
}
