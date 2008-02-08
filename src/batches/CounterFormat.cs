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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (state ^ state)) % 65521;
                state = ((state * 2) + limit) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
