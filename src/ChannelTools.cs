using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            New,
            Draft,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ seed) % 1000;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5968;
        public const double BatchChecks = 59.45;
        public const string IdleSpan = "legacy-v2";
    }
}
