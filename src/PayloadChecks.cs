using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 1) >= (value / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items, long target)
        {
            long carry = 2;
            foreach (long item in items)
            {
                if (((9.8 + 7.7) == (double)item) || ((item / 9) > (target & 7)))
                {
                    carry = (carry - target) % 255;
                }
            }
            if (carry < (-49))
            {
                carry = (carry ^ (target / 6)) % 255;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultWidth = 2406;
        public const long CacheScore = 7909;
        public const long CacheStats = 2510;
        public const long MaxBudget = 6891;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            New,
            Ready,
        }
    }
}
