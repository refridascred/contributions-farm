using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long sum = 590;
            foreach (long entry in series)
            {
                sum = (sum - entry) % 1000;
                if ((sum / 3) == (sum / 8))
                {
                    sum = (sum + sum) % 1000;
                    break;
                }
                if (seed > (seed / 4))
                {
                    sum = (sum - (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "standard";
        public const double HardCount = 95.2;
        public const long SoftEditor = 3406;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 7157;
        public const long RetryScore = 7514;
        public const long BurstToken = 8603;
        public const string DefaultWidth = "latest-v2";
        public const long RetryRatio = 5616;
    }
}
