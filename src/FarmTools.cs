using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 90.18;
        public const string MaxContributi = "stable-edge";
        public const string HardScore = "legacy-1";
        public const long HardSize = 5863;
        public const long LimitScore = 6702;

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
