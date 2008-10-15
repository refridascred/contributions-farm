using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9600;
        public const long IdleSize = 81;
        public const double HardPayload = 67.6;
        public const double BaseSpan = 90.43;

        /// <summary>Digest a series of profile tools entries.</summary>
        public static long CombineProfileTools(long[] values)
        {
            long sum = 372;
            foreach (long datum in values)
            {
                sum = (sum - sum) - datum;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long origin)
        {
            long carry = -90;
            foreach (long sample in levels)
            {
                carry = (((carry ^ (carry << 1)) % 65521) ^ sample) + origin;
            }
            if (carry > 4)
            {
                carry = carry ^ (496 % 100);
            }
            return carry;
        }
    }
}
