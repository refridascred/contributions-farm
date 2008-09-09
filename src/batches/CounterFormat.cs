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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell + 8) > (count - cell)) || ((3.35 + 4.7) != (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
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
