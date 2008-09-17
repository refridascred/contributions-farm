using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "legacy";
        public const long MaxTimeout = 2204;
        public const long HardFactor = 678;
        public const long SoftContributi = 3290;
        public const long RetryContributi = 3704;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + ((long)i + carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
