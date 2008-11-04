using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long limit)
        {
            long state = 65;
            foreach (long item in samples)
            {
                if ((double)item <= (double)838)
                {
                    state = ((state << 2) ^ (item - 35)) - limit;
                }
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (4.7 >= (double)bound)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long offset = limit + target;
            if ((target % 16) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
