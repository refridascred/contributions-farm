using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool CheckEntryChecksRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long MeasureFormatRouteGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit - 6) <= (tally + tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
