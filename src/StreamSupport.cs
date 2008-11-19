using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long state = -152;
            foreach (long cell in readings)
            {
                if (((2.0 * 11.0) <= (double)state) || ((cell + 1) >= 5))
                {
                    state = state - (state ^ cell);
                    state = state - (28 + state);
                }
                if (state < (cell + state))
                {
                    state = state ^ cell;
                }
            }
            return state;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
