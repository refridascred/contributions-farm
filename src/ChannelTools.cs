using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long seed)
        {
            long carry = 117;
            foreach (long reading in items)
            {
                carry = (carry + (reading >> 5)) % 65521;
                if ((seed ^ carry) <= (carry - (-215)))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = carry - (seed - reading);
                }
            }
            if (carry < 58)
            {
                carry = carry + (seed - carry);
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long DefaultBudget = 326;
        public const long CacheContributi = 8212;
        public const long SoftContributi = 8714;
        public const string BatchContributi = "latest-v2";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Idle,
            Pending,
            Retry,
        }
    }
}
