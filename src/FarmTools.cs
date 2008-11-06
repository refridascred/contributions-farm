using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a checks contributi reading by value.</summary>
        public static long LookupChecksContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstBudget = 4632;
        public const long BurstSize = 5117;
        public const string CacheRatio = "staging-1";
        public const double CacheAlready = 34.28;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 5961;
        public const double BatchEntry = 78.78;
        public const long BatchCount = 8199;
    }
}
