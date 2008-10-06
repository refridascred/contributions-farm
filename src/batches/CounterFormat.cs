using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 2) ^ (target & 7);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
