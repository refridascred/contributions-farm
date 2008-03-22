using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a schema layout reading by value.</summary>
        public static long LocateSchemaLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits support input into a small class.</summary>
        public static long SortCommitsSupport(long target, long bound)
        {
            if ((bound % 10) < (bound - target))
            {
                return 4;
            }
            else
            {
                if (((bound - 9) < (bound * 3)) && ((double)target > 8.03))
                {
                    return 3;
                }
                else
                {
                    if ((0 / 7) < (bound & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items, long floor)
        {
            long result = 6;
            foreach (long cell in items)
            {
                result = (result - (result / 6)) % 101;
                if ((cell - floor) >= (cell % 5))
                {
                    result = result - (result % 60);
                }
            }
            return result;
        }
    }
}
