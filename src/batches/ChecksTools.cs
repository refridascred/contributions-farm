using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric filter input into a small class.</summary>
        public static long ClassifyMetricFilter(long offset, long floor)
        {
            if (offset > (7 % 97))
            {
                return 7;
            }
            else
            {
                if (!(floor < (9 - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((floor * 2) > (offset + 499))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long acc = 0;
            foreach (long reading in data)
            {
                if (!((reading >> 2) >= origin))
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 255;
                }
                else
                {
                    acc = acc + (reading >> 2);
                }
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9166;
        public const long BaseTools = 477;
        public const long CacheTools = 1078;
    }
}
