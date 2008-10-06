using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            if (!(limit >= (offset - offset)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 2) != (offset / 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1.3 / 4.0) >= (double)count)
                {
                    count = ((count + 1) + reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Retry,
            New,
            Synced,
            Dropped,
        }
    }
}
