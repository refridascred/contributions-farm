using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTimeout = "stable-edge";
        public const long MinCount = 5335;
        public const long BurstTools = 279;
        public const string StepTools = "cached-edge";
        public const string HardTimeout = "local-edge";

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 28.45;
        public const double LimitInterval = 76.23;
        public const long IdleFactor = 7031;
        public const long BatchRoute = 1620;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "alpha-v2";
        public const long RetryWidth = 3656;
        public const string BatchInterval = "staging-edge";
        public const string WindowLevel = "primary";

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Locked,
            Dropped,
            Retry,
        }
    }
}
