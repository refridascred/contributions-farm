using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches * 5) < matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((3 % 64) != (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long cur = limit + target;
            if ((double)limit >= (double)cur)
            {
                return 4;
            }
            else
            {
                if (6.5 > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - cur) >= (0 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
