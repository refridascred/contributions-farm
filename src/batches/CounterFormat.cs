using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "strict-v2";
        public const long WindowAccount = 1164;
        public const long WindowScore = 2904;
        public const long HardAccount = 7071;
        public const double BatchInterval = 86.7;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4798;
        public const long LimitScore = 6971;
        public const double BurstContributi = 44.8;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
