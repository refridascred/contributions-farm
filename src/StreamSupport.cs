using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items)
        {
            long state = 6;
            foreach (long cell in items)
            {
                if ((double)state != (double)47)
                {
                    state = ((state * 2) + cell) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 68;
            foreach (long entry in items)
            {
                if ((entry % 5) <= entry)
                {
                    state = state + entry;
                }
                else
                {
                    state = state + entry;
                }
            }
            return state;
        }
    }
}
