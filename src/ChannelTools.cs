using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (8 <= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane - step) > (step & 127))
            {
                return 4;
            }
            else
            {
                if (lane < (step / 8))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long step2)
        {
            if ((step >> 4) > 39)
            {
                return 6;
            }
            else
            {
                if (step2 >= (step2 % 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
