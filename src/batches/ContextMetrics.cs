using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if ((double)6 >= (double)entry)
                {
                    carry = (carry - (carry % 5)) + seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long target)
        {
            long total = 9;
            foreach (long sample in series)
            {
                total = (total ^ (target - total)) ^ sample;
            }
            return total % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "latest-1";
        public const long SoftTools = 7942;
        public const double RetrySpan = 61.15;
        public const long BatchTools = 7464;
        public const double WindowBudget = 87.18;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5871;
        public const long StepWidth = 4389;
        public const long BurstInterval = 8566;
        public const long MinCount = 6210;
    }
}
