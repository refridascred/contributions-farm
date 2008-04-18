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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
