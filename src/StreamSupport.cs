using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ seed) % 101;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long tally = (mark << 1) >> 5;
                    mark = (mark + (mark ^ tally)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
