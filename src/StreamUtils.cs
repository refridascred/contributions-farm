using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleFactor = 3931;
        public const double MaxEditor = 22.06;
        public const string WindowRatio = "staging-v2";
        public const string DefaultScore = "fallback-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 4.95;
        public const long BurstWidth = 7589;
        public const string IdleStream = "alpha-v2";
        public const long MinStream = 313;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6265;
        public const string BaseChecks = "standard";
        public const long RetryWidth = 6897;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
