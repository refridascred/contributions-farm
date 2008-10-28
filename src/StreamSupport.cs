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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1041;
        public const double MinBatches = 52.56;
        public const string CacheBatches = "fallback";
        public const long HardSpan = 402;
        public const string SoftBatches = "strict-1";
    }
}
