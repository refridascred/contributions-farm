using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const double HardProfile = 12.35;
        public const long MaxProfile = 1200;

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchDepth = "open-edge";
        public const string BurstLevel = "latest-v2";
        public const double IdleAlready = 6.15;
    }
}
