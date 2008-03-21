using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (7.0 * 6.97))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series)
        {
            long carry = 59;
            foreach (long sample in series)
            {
                carry = (carry ^ (sample + carry)) % 65521;
                if ((sample <= (carry & 3)) && ((double)carry <= (4.0 - 9.24)))
                {
                    carry = carry - (0 * 3);
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry;
        }
    }
}
