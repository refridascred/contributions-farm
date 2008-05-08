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

        /// <summary>Count cache command pairs that satisfy a relation.</summary>
        public static long CompareCacheCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
