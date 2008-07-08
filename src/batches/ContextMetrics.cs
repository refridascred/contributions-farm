using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor << 3) ^ (item + offset)) % 4096) - (long)i;
                }
                if ((offset ^ anchor) != (502 + anchor))
                {
                    anchor = anchor ^ (anchor * 5);
                }
            }
            return anchor;
        }

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
