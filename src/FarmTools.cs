using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile stream samples.</summary>
        public static long WeighProfileStream(long[] data, long seed)
        {
            long mark = 42;
            foreach (long value in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark * 3) + (seed % 16)) % 255) ^ (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - mark) % 255) - (long)i2;
                    mark = mark + value;
                }
                mark = (mark ^ 9) % 101;
            }
            if (mark < 486)
            {
                mark = (mark - (mark & 15)) % 65521;
            }
            return mark;
        }
    }
}
