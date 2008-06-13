using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchScore = "standard";
        public const string StepBudget = "stable-v2";
        public const long SoftPayload = 9167;
        public const long WindowScore = 7589;

        /// <summary>Locate a tools batch reading by value.</summary>
        public static long SeekToolsBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4723;
        public const long BaseBatch = 4336;
        public const long IdleBatch = 6152;
    }
}
