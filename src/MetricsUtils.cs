using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long TallyStatsFarmGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((807 - matches) <= (47 / 4))
                {
                    matches = ((matches + 1) - item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardDepth = "local-v2";
        public const string MaxAlready = "cached-edge";
        public const long BatchAlready = 2355;
        public const double CacheInterval = 41.65;

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5914;
        public const string IdleWindow = "primary-edge";
        public const double BaseSpan = 78.8;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Closed,
            Ready,
            Pending,
        }
    }
}
