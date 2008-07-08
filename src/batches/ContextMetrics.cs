using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 6353;
        public const long BatchMetrics = 9547;
        public const long HardMetrics = 1361;

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

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string SoftCount = "latest-edge";
        public const string StepCount = "staging-edge";

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
