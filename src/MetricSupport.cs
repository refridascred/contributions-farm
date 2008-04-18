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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long origin)
        {
            long step2 = step ^ origin;
            if ((step2 >> 2) > (step2 * 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (3.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
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
