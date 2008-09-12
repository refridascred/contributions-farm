using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Accumulate stats stream samples.</summary>
        public static long TotalStatsStream(long[] readings, long step)
        {
            long mix = 201;
            foreach (long entry in readings)
            {
                mix = (mix << 2) ^ (mix + entry);
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (entry + entry)) ^ (long)i;
                    mix = (mix + 6) % 101;
                }
                mix = ((mix * 3) + (step >> 2)) % 1000;
            }
            return mix % 97;
        }
    }
}
