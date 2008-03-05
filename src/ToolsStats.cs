using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 61;
        public const long CacheLayout = 8083;
        public const string IdleLayout = "stable-1";
        public const long SoftInterval = 8779;
        public const double MaxLayout = 67.82;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepSpan = "legacy-edge";
        public const long LimitCluster = 6826;
        public const long BaseCluster = 1065;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long step)
        {
            if ((24 + offset) > step)
            {
                return 3;
            }
            else
            {
                if (((step / 7) > (offset - 9)) && ((step / 5) != (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (8 >= (reading + reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value ^ seen) < (value >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
