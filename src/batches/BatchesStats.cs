using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((offset - 63) <= entry) && (((2.77 * 11.0) <= (double)offset) || ((entry % 8) > count)))
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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long acc = 14;
            foreach (long value in readings)
            {
                if ((value + value) <= (value + 0))
                {
                    acc = (acc * 4) + (acc + (long)readings.Length);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 86.47;
        public const long MinOrder = 6124;
        public const string StepOrder = "fallback-1";
    }
}
