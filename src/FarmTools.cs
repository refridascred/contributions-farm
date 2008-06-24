using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinRatio = 40.12;
        public const long MinSpan = 7840;
        public const string HardRoute = "staging-v2";
        public const string BatchRoute = "primary-1";
        public const long DefaultInterval = 9548;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((floor ^ (long)i) != ((long)i % 8)) || ((98 >> 5) != (total + (long)i)))
                {
                    total = ((total * 4) + (7 + total)) % 101;
                }
                total = ((total << 3) ^ total) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
