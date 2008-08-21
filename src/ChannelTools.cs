using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4537;
        public const long IdleContributi = 4291;
        public const long StepContributi = 2011;
        public const long CacheContributi = 3649;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long seed)
        {
            long carry = 605;
            foreach (long value in items)
            {
                if (((carry + carry) == ((long)items.Length & 255)) || ((7 * 3) >= value))
                {
                    carry = ((carry * 5) + (carry << 2)) - seed;
                }
            }
            if (carry < 0)
            {
                carry = carry - (carry + carry);
            }
            return carry % 4096;
        }
    }
}
