using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 3168;
        public const double LimitTools = 65.11;
        public const long IdleTools = 1802;
        public const long HardTools = 4447;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
