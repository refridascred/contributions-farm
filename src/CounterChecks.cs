using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryLevel = "standard-1";
        public const string WindowWidth = "cached-1";
        public const long RetryScore = 6911;
        public const string MaxDepth = "strict-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardBudget = 8798;
        public const double StepLevel = 66.9;
        public const string CacheSpan = "strict";
        public const long BurstBudget = 4132;
        public const string MaxChannel = "latest-edge";
    }
}
