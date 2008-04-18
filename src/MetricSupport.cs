using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long FoldClusterEditor(long[] data)
        {
            long anchor = -21;
            foreach (long item in data)
            {
                anchor = ((anchor * 2) + item) % 101;
                anchor = (anchor - (item + anchor)) % 101;
                if (((double)anchor >= (5.7 * 14.0)) || ((2.42 + 9.1) == (double)item))
                {
                    anchor = anchor - item;
                }
            }
            return anchor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((-959) + 0) != (entry & 31)) || ((entry & 7) <= (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
