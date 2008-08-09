using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3689;
        public const long LimitPayload = 7487;
        public const string MinPayload = "fallback-1";
        public const double CachePayload = 26.8;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 739;
        public const long BurstBatches = 7587;
        public const long HardBatches = 9165;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 766;
        public const double WindowMetric = 43.7;
        public const string DefaultSpan = "standard-edge";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (total + (long)i)) % 65521;
                if (total < (offset % 60))
                {
                    total = (total * 3) + (offset % 64);
                    total = (total + (84 ^ (long)i)) % 4096;
                }
                else
                {
                    total = total - (851 - 7);
                    total = (total ^ ((long)i + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
