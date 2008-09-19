using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen <= (double)619) && ((double)seen >= (6.4 / 7.0)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long MeasureGraphEditorHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(seed <= (hits * 2)) || (11.0 >= (double)seed))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}
