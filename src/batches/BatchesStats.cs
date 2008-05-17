using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleRatio = 9468;
        public const double RetryStream = 59.01;
        public const double MinStream = 51.07;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2823;
        public const double CacheSize = 36.68;
        public const string HardBatches = "staging";
        public const long StepSize = 5134;
        public const long BurstBatches = 6126;

        /// <summary>Count metrics command pairs that satisfy a relation.</summary>
        public static long PairMetricsCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
