using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftCount = 3525;
        public const long MinBudget = 5024;
        public const long DefaultFactor = 2506;

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
