using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (seed ^ 442))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long TotalCommitsEditor(long[] data)
        {
            long total = 3;
            foreach (long item in data)
            {
                if (total > item)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                if ((item & 15) < (total + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
