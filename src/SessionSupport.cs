using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - ((long)i >> 5)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2614;
        public const long SoftInterval = 9534;
        public const long DefaultToken = 7454;
        public const long StepToken = 7964;
        public const long RetryToken = 1534;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
