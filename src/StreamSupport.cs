using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 8711;
        public const long LimitRecord = 6817;
        public const long DefaultRecord = 7696;
        public const double BaseInterval = 18.89;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Closed,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Roll a token session counter forward.</summary>
        public static long StepTokenSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 2) ^ (origin + origin)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
