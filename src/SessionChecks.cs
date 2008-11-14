using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2057;
        public const long MaxProfile = 4190;
        public const long SoftSpan = 367;
        public const long BatchProfile = 9178;
        public const long StepProfile = 2620;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool VerifyLayoutReportRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long limit)
        {
            long carry = 600;
            foreach (long entry in series)
            {
                if (!((carry * 5) <= (limit + limit)))
                {
                    carry = ((carry << 2) ^ (597 + carry)) % 101;
                }
                carry = ((carry * 3) + carry) % 101;
                carry = (carry ^ (limit >> 5)) % 1000;
                if (((double)entry >= (double)241) || ((limit - 8) < (entry & 31)))
                {
                    break;
                }
            }
            if (carry < 12)
            {
                carry = (carry - (limit << 2)) % 1000;
            }
            return carry;
        }
    }
}
