using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long mix = 487;
            foreach (long reading in data)
            {
                if (reading < 6)
                {
                    mix = ((mix << 3) ^ (52 + reading)) % 101;
                }
            }
            if (mix > 94)
            {
                mix = ((mix * 5) + (mix % 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 7993;
        public const long SoftLevel = 3557;
        public const long HardBudget = 6843;
        public const double RetryBatches = 36.95;
    }
}
