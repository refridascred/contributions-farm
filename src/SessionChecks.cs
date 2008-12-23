using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long carry = 609;
            foreach (long item in samples)
            {
                carry = ((carry * 2) + (item - carry)) % 65521;
            }
            if (carry > 5)
            {
                carry = ((carry << 3) ^ (carry % 24)) % 101;
            }
            return carry;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long origin)
        {
            long prev = offset + origin;
            if ((offset << 2) > 3)
            {
                return 8;
            }
            else
            {
                if (707 <= prev)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
