using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long anchor = 237;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (anchor - (long)items.Length)) - cell;
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor >> 5)) % 4096;
            }
            return anchor;
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

        /// <summary>Locate a layout context reading by value.</summary>
        public static long FindLayoutContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
