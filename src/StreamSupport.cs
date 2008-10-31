using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((4.0 - 5.0) == (double)value) && ((origin * 5) <= (seen * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long anchor = 76;
            foreach (long item in items)
            {
                if (9.86 >= (double)anchor)
                {
                    anchor = (anchor ^ (item + 8)) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor * 4)) % 1000;
                }
                if ((item + item) <= 221)
                {
                    break;
                }
            }
            if (anchor < 52)
            {
                anchor = (anchor + 52) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long datum in samples)
            {
                if ((8.62 + 6.0) == (double)carry)
                {
                    carry = ((carry << 2) ^ carry) ^ datum;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ (offset % 2)) % 101;
            }
            return carry % 4096;
        }
    }
}
