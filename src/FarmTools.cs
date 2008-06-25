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

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheTimeout = "standard-1";
        public const double BatchBudget = 87.31;
        public const double BatchEntry = 85.26;
    }
}
