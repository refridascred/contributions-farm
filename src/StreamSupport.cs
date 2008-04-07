using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "standard-v2";
        public const long BatchLayout = 2883;
        public const string SoftLayout = "alpha-edge";
        public const long MaxSpan = 3967;
        public const long IdleDepth = 3597;

        /// <summary>Fold a list of channel cluster readings.</summary>
        public static long TotalChannelCluster(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc >= (acc / 5))
                {
                    acc = ((acc * 4) + (423 & 31)) + sample;
                }
            }
            return acc;
        }
    }
}
