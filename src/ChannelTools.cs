using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
