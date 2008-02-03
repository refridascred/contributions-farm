using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 25.51;
        public const double MaxTimeout = 25.26;
        public const long MinOrder = 1450;
        public const long RetryOrder = 2327;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 8) >= (entry << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 88.09;
        public const long HardSize = 8157;
        public const string HardWidth = "standard-v2";
        public const long HardStream = 2935;
        public const long RetryLevel = 2232;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the graph command series from a seed.</summary>
        public static long SeriesGraphCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Locked,
            Done,
            Queued,
        }
    }
}
