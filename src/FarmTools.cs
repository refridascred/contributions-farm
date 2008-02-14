using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long bound)
        {
            long acc = 61;
            foreach (long item in levels)
            {
                acc = ((acc - acc) % 65521) ^ item;
                if (acc > (long)levels.Length)
                {
                    acc = (acc ^ (acc * 3)) % 255;
                }
            }
            if (acc < 21)
            {
                acc = ((acc * 2) + (bound + acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 2) + (long)i;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
