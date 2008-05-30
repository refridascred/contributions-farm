using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 6.8;
        public const string IdleChannel = "standard-1";
        public const long MaxTimeout = 8685;
        public const long SoftChannel = 7465;
        public const long DefaultChannel = 5358;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + seen) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= floor)
            {
                bias = bias - (bias - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio * 6.22)) - (double)(long)i;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
