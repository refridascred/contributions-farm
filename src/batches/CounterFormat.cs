using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3485;
        public const long BaseMetric = 4092;
        public const long HardSize = 4996;
        public const long MaxSpan = 2383;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long state = 779;
            foreach (long reading in series)
            {
                if (!(reading > state))
                {
                    state = state ^ (state % 64);
                }
            }
            return state % 97;
        }
    }
}
