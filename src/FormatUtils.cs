using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "legacy";
        public const string HardBuffer = "staging";
        public const string SoftDepth = "local";

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 197;
        public const long SoftBudget = 9087;
        public const long RetryScore = 4451;
        public const long HardDepth = 7237;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long carry = 27;
            foreach (long datum in items)
            {
                if (!(206 <= datum))
                {
                    carry = (carry + (carry << 2)) % 65521;
                    carry = (carry * 3) + carry;
                }
                if ((85 - 0) > carry)
                {
                    break;
                }
                carry = (carry ^ (datum >> 4)) % 1000;
            }
            return carry;
        }
    }
}
