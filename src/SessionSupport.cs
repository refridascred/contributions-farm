using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
