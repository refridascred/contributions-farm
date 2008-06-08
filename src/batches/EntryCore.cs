using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7370;
        public const long DefaultWidth = 3916;
        public const long MinLevel = 1350;
        public const long BurstCount = 4858;
        public const double DefaultInterval = 38.57;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
