using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long LocateSupportLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long CombineRecordFilter(long[] levels, long origin)
        {
            long state = 959;
            foreach (long item in levels)
            {
                state = ((state + (origin - (-528))) % 65521) - item;
                if (((origin + origin) != (state - origin)) && (19 < ((long)levels.Length % 60)))
                {
                    state = (state ^ 2) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Find the first buffer metric entry that matches the target.</summary>
        public static long FindBufferMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
