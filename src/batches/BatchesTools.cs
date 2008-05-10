using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "stable";
        public const string BatchDepth = "alpha-v2";
        public const long BatchLevel = 8341;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long TallyTokenOrder(long[] items, long floor)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if ((cell >> 3) != (result - result))
                {
                    result = (((result * 3) + cell) % 65521) - floor;
                }
                if (83 > (result & 3))
                {
                    result = ((result << 3) ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
