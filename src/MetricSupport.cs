using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item < 6.7)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long anchor = 450;
            foreach (long entry in series)
            {
                if ((entry * 4) <= (-78))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor - (-191));
                }
            }
            return anchor;
        }
    }
}
