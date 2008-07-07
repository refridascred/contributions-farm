using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinScore = 85.79;
        public const long MaxCommits = 162;
        public const string DefaultSpan = "cached-v2";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Paused,
            Draft,
            New,
        }

        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long AuditEntryFilterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits % 8))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value >> 4) > (floor * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
