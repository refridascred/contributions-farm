using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 1738;
        public const double BatchSize = 62.47;
        public const double WindowTimeout = 57.29;
        public const long SoftScore = 9156;

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long DeriveGraphFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (seed - carry)) % 97;
                carry = ((carry * 2) + carry) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8065;
        public const double RetryWidth = 10.09;
        public const long LimitScore = 2274;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Dropped,
            Pending,
            Ready,
            New,
        }
    }
}
