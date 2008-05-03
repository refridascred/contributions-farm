using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((6 + carry) < (datum + datum))
                {
                    carry = (carry + (carry / 8)) % 4096;
                }
            }
            if (carry > 79)
            {
                carry = (carry * 3) + 958;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((8.85 - 9.0) <= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
