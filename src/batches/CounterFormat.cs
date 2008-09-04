using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] readings, long step)
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3301;
        public const long BurstEntry = 1313;
        public const long BatchDepth = 4855;
        public const string MaxScore = "fallback";
        public const long LimitSize = 1281;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
