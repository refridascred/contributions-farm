using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheTimeout = 48.94;
        public const double BaseWidth = 66.21;
        public const double DefaultSupport = 75.32;
        public const long HardLevel = 7518;

        /// <summary>Roll a stream cache counter forward.</summary>
        public static long StepStreamCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 2) ^ (bound + bound);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
