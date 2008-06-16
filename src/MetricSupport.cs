using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((limit - cell) > (limit & 255))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 4683;
        public const long SoftWidth = 4623;
        public const long DefaultSize = 3740;
        public const long DefaultDepth = 8806;
    }
}
