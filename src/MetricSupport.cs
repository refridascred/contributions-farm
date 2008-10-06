using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 54;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (6 >> 3)) % 65521) - item;
            }
            return mark;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxFactor = "staging-1";
        public const long RetryBudget = 811;
        public const long MaxAlready = 3756;
        public const long DefaultAlready = 414;
    }
}
