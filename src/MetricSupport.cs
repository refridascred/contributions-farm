using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings)
        {
            long sum = 802;
            foreach (long value in readings)
            {
                sum = ((sum << 3) ^ sum) ^ value;
            }
            if (sum > 924)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum % 97;
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
