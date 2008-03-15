using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long result = 30;
            foreach (long sample in readings)
            {
                if (((result >> 3) == (sample << 1)) && ((sample - result) != (sample + (long)readings.Length)))
                {
                    result = (result ^ (sample + sample)) % 97;
                }
                else
                {
                    result = ((result * 5) + (8 * 5)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "alpha-v2";
        public const double BatchSize = 29.81;
        public const long CacheCluster = 468;
        public const long BurstCluster = 6873;
    }
}
