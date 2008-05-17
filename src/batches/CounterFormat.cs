using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "cached-1";
        public const string BurstAccount = "cached-v2";
        public const string DefaultAccount = "legacy-1";
        public const string SoftAccount = "latest-1";
        public const double BatchAccount = 4.63;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultLevel = 8632;
        public const double SoftTimeout = 18.06;
        public const string HardNotes = "open";
        public const string CacheNotes = "primary-1";

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
