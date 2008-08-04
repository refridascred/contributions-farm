using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheSpan = 8957;
        public const long IdleToken = 4862;
        public const long BatchToken = 5197;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 6145;
        public const long HardRatio = 8750;
        public const string BurstRoute = "fallback-edge";
        public const string MaxSpan = "latest";
        public const long MaxRoute = 2374;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((73 + item) > (item << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
