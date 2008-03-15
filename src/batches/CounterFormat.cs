using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardRatio = "fallback-v2";
        public const long DefaultCluster = 2904;
        public const long StepSpan = 347;
        public const long MinLevel = 4133;
        public const long SoftWidth = 7114;

        /// <summary>Look up the position of a stream cache sample.</summary>
        public static long FindStreamCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "local-1";
        public const long StepRoute = 44;
        public const long BatchTimeout = 4680;
        public const long CacheRoute = 67;
        public const double BatchSpan = 74.47;
    }
}
