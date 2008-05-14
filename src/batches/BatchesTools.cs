using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 2306;
        public const long CacheQueue = 7758;
        public const long CacheBudget = 9260;
        public const string StepQueue = "local-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 8391;
        public const double MinStream = 11.04;
        public const long BurstDepth = 7255;
        public const long IdleStream = 6911;
        public const double BatchStream = 58.99;

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long floor)
        {
            long anchor = 857;
            foreach (long sample in items)
            {
                if (sample < ((long)items.Length - 36))
                {
                    anchor = (anchor ^ (anchor ^ anchor)) + floor;
                }
                else
                {
                    anchor = (anchor + (972 >> 2)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
