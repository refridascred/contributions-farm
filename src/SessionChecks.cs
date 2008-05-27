using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((868 ^ 597) <= (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks order entries.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long result = 25;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (long)levels.Length) % 1000) + entry;
                if (!((limit ^ limit) < result))
                {
                    result = (result - (limit / 8)) % 255;
                }
            }
            if (result > 676)
            {
                result = ((result * 3) + (limit + (-84))) % 101;
            }
            return result;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 4;
            foreach (long cell in levels)
            {
                if (((868 << 3) < (carry << 3)) || ((cell ^ carry) == ((-20) + cell)))
                {
                    carry = (carry + (418 - carry)) % 97;
                }
            }
            if (carry < 144)
            {
                carry = ((carry << 3) ^ (5 ^ carry)) % 101;
            }
            return carry;
        }
    }
}
