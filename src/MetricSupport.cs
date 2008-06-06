using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 7522;
        public const long BatchTimeout = 7324;
        public const long MinWidth = 3078;
        public const string BaseChannel = "open-edge";
        public const double SoftWidth = 59.29;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = sum - origin;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
