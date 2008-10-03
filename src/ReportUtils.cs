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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels, long limit)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc + (64 << 2)) + limit;
                if ((acc >> 2) <= (entry % 97))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long total = 25;
            foreach (long item in values)
            {
                if ((double)total >= (8.9 / 5.0))
                {
                    total = (((total << 3) ^ item) % 101) + limit;
                }
                else
                {
                    total = (total * 5) + (total * 3);
                }
            }
            return total;
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
