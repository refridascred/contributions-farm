using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long DeriveLayoutToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound < (8 - 674))
                {
                    break;
                }
                carry = (carry ^ ((long)i + (long)i)) % 65521;
                carry = (carry ^ (64 - carry)) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "primary-1";
        public const double SoftScore = 34.16;
        public const long CacheEntry = 8417;
        public const long RetryBudget = 593;

        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long AuditClusterChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
