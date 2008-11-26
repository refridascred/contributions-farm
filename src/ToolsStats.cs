using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
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
