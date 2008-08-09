using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 17.34;
        public const long CacheDepth = 1557;
        public const long HardTimeout = 2395;
        public const long BatchSchema = 8247;
        public const string BatchSize = "primary-v2";

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
