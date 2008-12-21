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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] series, long step)
        {
            long state = 30;
            foreach (long entry in series)
            {
                if ((state >> 4) >= (step * 5))
                {
                    break;
                }
                state = ((state - 510) % 97) ^ entry;
            }
            if (state > 9)
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
