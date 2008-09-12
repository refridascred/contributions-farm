using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5189;
        public const long BaseCount = 353;
        public const string BurstWidth = "strict-1";

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long origin)
        {
            long state = 33;
            foreach (long value in series)
            {
                state = (state - (value - origin)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a batches command reading by value.</summary>
        public static long LookupBatchesCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
