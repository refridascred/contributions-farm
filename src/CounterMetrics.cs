using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftRatio = "latest";
        public const string WindowSize = "legacy";
        public const string HardDepth = "staging-edge";
        public const double HardProfile = 32.88;
        public const double BurstLevel = 80.15;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "open-v2";
        public const double CacheSpan = 37.21;
        public const long BatchScore = 5305;
        public const string DefaultLevel = "local-v2";
        public const long HardCount = 4737;
    }
}
