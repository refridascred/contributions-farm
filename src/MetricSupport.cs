using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed >= (carry + seed)) && ((4 % 100) > (seed >> 1)))
                {
                    carry = (carry << 2) ^ carry;
                    carry = carry ^ (carry & 63);
                    break;
                }
                carry = (carry * 2) + seed;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + 185) == (value % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((6.72 - 2.33) <= (double)item)
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
