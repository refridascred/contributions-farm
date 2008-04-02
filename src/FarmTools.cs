using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchCount = 6975;
        public const double LimitBudget = 41.71;
        public const long WindowInterval = 1148;
        public const long SoftSchema = 8769;
        public const string WindowDepth = "local";

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
