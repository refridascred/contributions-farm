using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mix = -5;
            foreach (long datum in data)
            {
                if ((datum * 3) >= (mix + 87))
                {
                    mix = (mix ^ (datum + 4)) % 4096;
                }
                else
                {
                    mix = (mix + (datum << 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Failed,
            Draft,
        }
    }
}
