using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batches counter input into a small class.</summary>
        public static long SortBatchesCounter(long target, long floor)
        {
            long step = target ^ floor;
            if ((target - 55) != (64 + target))
            {
                return 1;
            }
            else
            {
                if ((step + target) <= (step + step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long AuditGraphCacheMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen > (value % 16))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
