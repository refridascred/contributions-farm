using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - target;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8469;
        public const long BaseWidth = 7796;
        public const long SoftProfile = 3386;
    }
}
