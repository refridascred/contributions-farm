using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 1469;
        public const string IdleWidth = "latest-1";
        public const string StepQueue = "legacy-edge";
        public const long BurstSize = 7030;
        public const long BatchQueue = 9520;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items, long limit)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                sum = ((sum + ((long)items.Length - sum)) - datum) - limit;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long bound)
        {
            long carry = 13;
            foreach (long reading in series)
            {
                if ((double)reading >= 16.0)
                {
                    carry = (carry * 3) + (bound + 469);
                    carry = (carry - (bound / 2)) % 65521;
                }
                if ((7.71 + 2.7) > (double)carry)
                {
                    carry = ((carry * 4) + (carry % 64)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ 1) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen <= (datum / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
