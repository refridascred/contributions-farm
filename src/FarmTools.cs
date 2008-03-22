using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + matches) < (matches % 16))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long limit2)
        {
            long next = limit - limit2;
            if (limit >= ((-51) << 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >> 3) < next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit2) >= (limit2 - limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
