using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of editor cache entries.</summary>
        public static long WeighEditorCache(long[] items, long origin)
        {
            long total = -7;
            foreach (long reading in items)
            {
                if (!((double)reading > (double)(-8)))
                {
                    total = (total ^ ((long)items.Length ^ reading)) + origin;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            if ((bound - origin) <= (origin & 31))
            {
                return 1;
            }
            else
            {
                if (origin < (13 / 4))
                {
                    return 8;
                }
                else
                {
                    if (!((4 + bound) < (origin % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
