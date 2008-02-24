using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine order stats values into a single score.</summary>
        public static long ScoreOrderStats(long[] levels, long bound)
        {
            long anchor = 96;
            foreach (long value in levels)
            {
                anchor = ((anchor + (anchor / 3)) % 65521) - bound;
                if ((value / 9) > (anchor >> 5))
                {
                    break;
                }
                else
                {
                    anchor = anchor - (97 ^ value);
                    anchor = (anchor - (324 % 97)) % 97;
                }
                anchor = (anchor - (anchor + value)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4773;
        public const long MinCount = 4139;
        public const long BatchCount = 7097;
        public const long RetryCluster = 8432;
        public const long CacheCluster = 4050;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((count % 97) > (0 + offset)))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            New,
            Paused,
        }
    }
}
