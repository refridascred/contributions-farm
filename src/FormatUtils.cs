using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1500;
        public const long WindowScore = 1487;
        public const long DefaultReport = 6798;
        public const long SoftReport = 9821;
        public const long IdleReport = 5430;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 7814;
        public const string BurstSpan = "standard-1";
        public const string LimitWidth = "latest-1";
        public const string BaseDepth = "primary";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.4 - 5.35) < (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
