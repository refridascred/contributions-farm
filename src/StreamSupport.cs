using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 8630;
        public const long BurstWidth = 4482;
        public const string IdleRatio = "stable-v2";

        /// <summary>Locate a graph record reading by value.</summary>
        public static long SeekGraphRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1041;
        public const double MinBatches = 52.56;
        public const string CacheBatches = "fallback";
        public const long HardSpan = 402;
        public const string SoftBatches = "strict-1";
    }
}
