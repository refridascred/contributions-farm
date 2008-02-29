using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)53)
            {
                ratio = ratio + (double)4;
            }
            return ratio - rate;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long acc = 442;
            foreach (long datum in samples)
            {
                if ((double)origin > (10.0 * 6.61))
                {
                    acc = (acc + (-362)) - datum;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin + origin)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i / 9)) % 4096;
                if ((3 + (long)i) > bound)
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
