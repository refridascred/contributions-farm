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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((3.0 / 2.0) <= (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
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
