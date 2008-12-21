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

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long bound)
        {
            long state = -15;
            foreach (long cell in levels)
            {
                if ((((-11) + 210) != (cell >> 1)) && ((double)(-84) >= (double)cell))
                {
                    state = (state + state) + bound;
                }
            }
            if (state > 4)
            {
                state = ((state << 2) ^ state) % 65521;
            }
            return state;
        }
    }
}
