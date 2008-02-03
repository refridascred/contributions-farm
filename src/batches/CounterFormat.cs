using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8483;
        public const double MinBuffer = 83.74;
        public const long MinRatio = 1041;
        public const long HardBuffer = 8360;
        public const string MaxBuffer = "fallback-1";

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "cached-v2";
        public const long DefaultSupport = 4828;
        public const string BaseCount = "strict-1";
        public const double IdleLevel = 31.47;
        public const double DefaultScore = 49.87;
    }
}
