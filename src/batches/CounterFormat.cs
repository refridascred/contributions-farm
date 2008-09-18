using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleDepth = 80.49;
        public const long MaxCounter = 854;
        public const string DefaultCounter = "standard-v2";
        public const long SoftSpan = 7939;
    }
}
