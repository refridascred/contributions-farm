using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4559;
        public const long DefaultCommand = 8035;
        public const long RetryCommand = 2172;
        public const long CacheCommand = 8621;
        public const long SoftCommand = 8307;

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowTimeout = "fallback-v2";
        public const long LimitReport = 2197;
        public const long HardReport = 5858;
        public const long BaseReport = 745;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
