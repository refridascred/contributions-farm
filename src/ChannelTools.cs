using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryInterval = 91.35;
        public const long BatchScore = 5147;
        public const double StepLevel = 34.44;
        public const string SoftSize = "fallback-v2";
        public const string MinTimeout = "stable-edge";

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 6104;
        public const long CacheLevel = 8533;
        public const double MinSize = 25.72;
        public const double BaseFarm = 84.32;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
