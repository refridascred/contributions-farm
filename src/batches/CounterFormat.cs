using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7134;
        public const long MinChannel = 7485;
        public const string HardInterval = "cached";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
