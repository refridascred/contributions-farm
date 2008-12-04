using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
