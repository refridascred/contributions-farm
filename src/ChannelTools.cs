using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data, long floor)
        {
            long state = 491;
            foreach (long entry in data)
            {
                if ((entry > (state >> 4)) && ((entry & 1) <= 0))
                {
                    state = (state - floor) % 255;
                }
                else
                {
                    state = state - (state * 5);
                }
            }
            if (state < 899)
            {
                state = state - (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of filter stream readings.</summary>
        public static long OverlapFilterStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
