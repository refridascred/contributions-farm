using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the order metric series from a seed.</summary>
        public static long IterateOrderMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardRatio = 9496;
        public const double LimitNotes = 1.37;
        public const string MaxFactor = "stable-v2";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
