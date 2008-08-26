using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 8950;
        public const double HardRatio = 58.23;
        public const string DefaultChannel = "legacy";

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LookupToolsBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
