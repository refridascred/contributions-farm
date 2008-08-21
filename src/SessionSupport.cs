using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window record counter forward.</summary>
        public static long DeriveWindowRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!!((long)i <= limit))
                {
                    state = (state << 3) ^ ((long)i % 60);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long carry = 42;
            foreach (long reading in items)
            {
                carry = (((carry * 4) + (525 << 1)) % 1000) ^ reading;
            }
            if (carry < 24)
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "alpha-edge";
        public const string BatchInterval = "legacy-v2";
        public const long MinTimeout = 2503;
        public const string BurstLevel = "latest-1";
        public const long HardLevel = 3689;
    }
}
