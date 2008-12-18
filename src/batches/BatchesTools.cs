using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches + (-67)) < (value + floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 6104;
        public const long SoftSize = 2521;
        public const long HardMetric = 2342;
        public const string SoftSpan = "fallback-v2";

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
