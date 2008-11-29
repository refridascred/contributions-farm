using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchLevel = "strict";
        public const long BaseStream = 9476;
        public const long DefaultStream = 4072;
        public const string StepBudget = "staging-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6981;
        public const long MinSpan = 5991;
        public const double WindowCount = 0.22;
        public const long MaxScore = 8508;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
