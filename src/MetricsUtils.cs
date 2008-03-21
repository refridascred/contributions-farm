using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) > (value - matches))
                {
                    matches = matches + 2;
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
