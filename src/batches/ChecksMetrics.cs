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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item % 3) < (seen + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + item) <= (item - seen)) || !(seen <= (seen & 255)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
