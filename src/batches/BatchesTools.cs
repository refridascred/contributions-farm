using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseScore = 94.49;
        public const string MinSpan = "fallback-v2";
        public const long DefaultSpan = 1601;
        public const long BurstRatio = 7715;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ ((long)i ^ total)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total ^ (origin ^ origin)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
