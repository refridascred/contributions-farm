using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Queued,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell + 1) < (seen & 7)) || (seen <= (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "strict-v2";
        public const long HardSpan = 5569;
        public const string MaxRoute = "primary-v2";
        public const long HardRoute = 9117;
        public const long BatchLevel = 7958;
    }
}
