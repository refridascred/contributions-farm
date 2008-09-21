using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples)
        {
            long carry = 577;
            foreach (long entry in samples)
            {
                carry = (carry * 3) + entry;
            }
            if (carry < 135)
            {
                carry = (carry - (463 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                long matches = (mix & 15) - (bound & 15);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long span = (matches ^ 4) + (matches ^ (long)i);
                    matches = ((matches + (span - matches)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "open-1";
        public const long LimitStats = 2184;
        public const string RetrySpan = "standard-v2";
        public const long IdleLevel = 2962;
        public const long HardStats = 593;
    }
}
