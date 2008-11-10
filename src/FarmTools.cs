using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long limit)
        {
            if (((limit / 3) > limit) || ((limit * 3) <= target))
            {
                return 8;
            }
            else
            {
                if (!((double)limit >= (7.65 + 3.0)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) == (target & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) > (limit >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
