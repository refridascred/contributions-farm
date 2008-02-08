using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long offset2)
        {
            if ((offset + offset2) >= offset2)
            {
                return 0;
            }
            else
            {
                if ((double)offset2 <= (3.21 + 2.2))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 - 4.27) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((((total << 2) ^ ((long)levels.Length >> 3)) % 1000) ^ (long)i2) ^ sample;
                }
                total = total ^ (43 - 75);
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long LocateSessionOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
