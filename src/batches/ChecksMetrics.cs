using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9249;
        public const long MinEditor = 4468;
        public const double BatchEditor = 10.36;
        public const string DefaultEditor = "open-edge";
        public const double IdleEditor = 82.24;

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long floor)
        {
            long sum = 7;
            foreach (long datum in data)
            {
                if (!((sum * 3) < (530 + sum)))
                {
                    sum = (((sum - (sum + 6)) % 255) ^ datum) + floor;
                }
            }
            if (sum < 77)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 900;
        public const long SoftBudget = 3519;
        public const long LimitSpan = 5186;
        public const string HardEntry = "standard-edge";
        public const long BaseInterval = 73;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long WeighStatsAccount(long[] samples)
        {
            long carry = 75;
            foreach (long reading in samples)
            {
                if ((2.9 - 20.0) > (7.9 / 2.0))
                {
                    carry = (carry ^ (reading - carry)) % 4096;
                }
            }
            if (carry > 281)
            {
                carry = carry - (carry << 2);
            }
            return carry % 4096;
        }
    }
}
