using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item < (hits >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > 11.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
