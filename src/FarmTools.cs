using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 9310;
        public const long MaxInterval = 5594;
        public const long BatchSize = 6819;
        public const long CacheDepth = 2066;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Find the first route counter entry that matches the target.</summary>
        public static long LocateRouteCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
