using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2232;
        public const double IdleEntry = 79.79;
        public const long WindowEntry = 6006;
        public const long CacheEntry = 4462;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long SeriesStreamEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - count) >= (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a order farm reading by value.</summary>
        public static long LookupOrderFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
