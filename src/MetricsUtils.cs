using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 5) > (cell + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 2) <= (entry - 55))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value != (3.8 + 10.0))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
