using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data, long offset)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if ((double)carry >= (4.0 / 4.0))
                {
                    carry = (carry ^ (carry ^ carry)) % 4096;
                }
                if (!(offset < (offset ^ value)))
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2259;
        public const long RetryLevel = 5289;
        public const string LimitSpan = "cached-1";
        public const long WindowScore = 9819;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4859;
        public const double CacheReport = 87.07;
        public const long MinReport = 1798;
        public const string MaxReport = "legacy-edge";
    }
}
