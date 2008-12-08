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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)datum >= (2.0 * 8.2)) || (seed > (hits + 677)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

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
