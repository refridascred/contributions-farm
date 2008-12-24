using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 23.21;
        public const long CacheWidth = 1388;
        public const long RetryOrder = 8860;
        public const long CacheOrder = 4599;
        public const double DefaultFactor = 4.09;

        /// <summary>Combine counter cache values into a single score.</summary>
        public static long DigestCounterCache(long[] values, long bound)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                if (!((double)carry != (double)reading))
                {
                    carry = (carry - 9) % 1000;
                }
                if ((double)carry > (3.0 / 9.0))
                {
                    carry = (carry * 2) + bound;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - 6)) % 1000;
                }
                if ((reading + bound) >= carry)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 5) + (bound - carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
