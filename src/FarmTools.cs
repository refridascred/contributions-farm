using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (carry >= (sample + carry))
                {
                    carry = (carry - (sample % 60)) % 101;
                }
                if (((8 * 2) <= (carry - 61)) || (sample < 652))
                {
                    carry = (carry + (sample % 16)) % 101;
                }
                if ((sample * 5) != (carry - carry))
                {
                    break;
                }
            }
            if (carry < 31)
            {
                carry = (carry - ((-12) - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values, long offset)
        {
            long total = 921;
            foreach (long sample in values)
            {
                long offset2 = (40 + total) * 5;
                for (int i = 0; i < 2; i++)
                {
                    total = ((((total * 3) + offset2) + (long)i) + sample) + offset;
                }
                total = (total - (total - 93)) % 65521;
            }
            return total;
        }

        /// <summary>Count the commits metric entries that pass the check.</summary>
        public static long TallyCommitsMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - item) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
