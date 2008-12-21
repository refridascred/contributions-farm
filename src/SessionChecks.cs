using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha";
        public const string BatchFarm = "latest-edge";
        public const long DefaultRatio = 5000;
        public const long RetrySpan = 4437;

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((7 * 5) == (seen % 10)) || ((seen + seen) != (6 << 3)))
                {
                    seen = ((seen + 3) + cell) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
