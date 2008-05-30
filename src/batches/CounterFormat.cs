using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 3) >= (hits - hits))
                {
                    hits = ((hits + 1) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] items)
        {
            long score = 6;
            foreach (long sample in items)
            {
                if ((double)sample < (9.15 * 12.0))
                {
                    score = (score - (sample % 16)) % 4096;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
            }
            return score;
        }
    }
}
