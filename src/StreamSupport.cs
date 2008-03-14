using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 9387;
        public const long SoftTimeout = 8330;
        public const long RetryAlready = 3218;
        public const double CacheAlready = 79.54;
        public const long HardInterval = 487;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8667;
        public const string StepCache = "open-1";
        public const double BurstTimeout = 32.24;
        public const double LimitCache = 69.12;
        public const long BatchCache = 6450;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((carry >> 5) >= bound)
                {
                    carry = carry + bound;
                }
                else
                {
                    carry = ((carry * 5) + (carry * 3)) % 101;
                    carry = (carry * 3) + bound;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
