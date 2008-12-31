using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchCount = 4449;
        public const double BurstInterval = 53.82;
        public const long WindowDepth = 6775;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record filter measurements.</summary>
        public static double ProjectRecordFilter(double rate, double offset)
        {
            double weight = offset / 5.0;
            return (weight - (weight - weight)) + rate;
        }
    }
}
