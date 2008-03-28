using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "standard-edge";
        public const long BaseStream = 5923;
        public const long StepInterval = 7238;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
