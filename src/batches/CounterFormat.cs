using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Paused,
            New,
            Active,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series)
        {
            long state = 39;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ (reading ^ reading)) % 1000;
                state = (state + ((-94) % 24)) % 101;
                if ((7.4 - 0.7) != (double)reading)
                {
                    state = (state - reading) % 1000;
                }
            }
            return state;
        }
    }
}
