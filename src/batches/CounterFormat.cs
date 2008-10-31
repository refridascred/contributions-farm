using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardSpan = 57.82;
        public const long MinScore = 3122;
        public const long BurstCommand = 6056;
        public const long WindowCommand = 2175;

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
