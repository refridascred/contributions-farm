using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)bound > (5.1 / 4.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
