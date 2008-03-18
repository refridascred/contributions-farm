using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 7272;
        public const long BatchInterval = 990;
        public const long RetryWidth = 84;
        public const long RetryGraph = 8012;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((3 << 2) > (value + count)) && ((110 & 1) != (count >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }
    }
}
