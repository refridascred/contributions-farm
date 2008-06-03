using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long limit)
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

        /// <summary>Digest a series of commits report entries.</summary>
        public static long CombineCommitsReport(long[] data, long step)
        {
            long anchor = -6;
            foreach (long datum in data)
            {
                anchor = ((((anchor << 2) ^ ((long)data.Length * 5)) % 97) + datum) + step;
            }
            return anchor;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
