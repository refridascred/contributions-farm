using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3688;
        public const long DefaultSchema = 4173;
        public const long MaxSchema = 1266;

        /// <summary>Roll a batches metrics counter forward.</summary>
        public static long RollBatchesMetrics(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 3048;
        public const long HardFactor = 7337;
        public const string StepSpan = "cached-edge";
    }
}
