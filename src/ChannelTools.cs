using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batches account reading by value.</summary>
        public static long FindBatchesAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 8667;
        public const string BurstDepth = "fallback-edge";
        public const string DefaultMetrics = "legacy";
        public const string HardMetrics = "strict";
        public const long LimitMetrics = 8890;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
