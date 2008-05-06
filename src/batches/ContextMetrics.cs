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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSpan = 1845;
        public const double BaseRoute = 50.33;
        public const double MaxRoute = 96.8;
        public const string LimitSize = "staging-edge";
        public const long WindowWidth = 5431;
    }
}
