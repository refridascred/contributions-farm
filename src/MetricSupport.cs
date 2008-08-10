using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) >= (entry - 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 7416;
        public const string CacheCount = "open";
        public const long LimitCommits = 6311;
        public const long CacheCommits = 180;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
