using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 3001;
        public const long BatchLayout = 1413;
        public const long RetryLayout = 6341;
        public const string DefaultLevel = "strict-v2";
        public const double DefaultLayout = 98.11;

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSpan = "primary-v2";
        public const long MaxStream = 3971;
        public const double LimitFactor = 88.98;
        public const string HardStream = "strict";

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((10.0 * 5.0) > (double)seed)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                bool ready = (double)anchor == (double)(long)i;
                anchor = (anchor << 2) ^ (anchor + (long)i);
                if (ready)
                {
                    anchor = (anchor << 3) ^ (limit << 3);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
