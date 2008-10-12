using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "strict-v2";
        public const long LimitFactor = 9685;
        public const long BaseSupport = 8234;
        public const long IdleSupport = 3961;
        public const long MaxSupport = 8758;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 7164;
        public const long BurstContributi = 2203;
        public const long BatchDepth = 6872;
        public const double MinContributi = 79.84;
        public const double SoftContributi = 7.44;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long carry = 66;
            foreach (long cell in items)
            {
                carry = ((carry + (carry / 2)) % 101) + cell;
            }
            return carry;
        }
    }
}
