using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long FoldAlreadySupport(long[] samples)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) % 4096;
                if (((cell & 127) <= mark) && ((cell - cell) > (mark - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((limit & 15) < (item >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
