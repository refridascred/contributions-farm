using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultRatio = 1650;
        public const long BatchLayout = 3516;
        public const long SoftDepth = 977;
        public const long StepLayout = 3928;
        public const string CacheWidth = "local-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9738;
        public const string SoftLevel = "legacy-1";
        public const long RetryBatch = 9738;

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
