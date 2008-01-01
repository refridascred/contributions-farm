using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long anchor = -114;
            foreach (long datum in series)
            {
                if (((2.34 * 9.1) < (double)origin) && ((anchor >> 5) > (datum - datum)))
                {
                    anchor = (anchor * 2) + (origin + origin);
                }
                else
                {
                    anchor = (anchor + (41 % 10)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long carry = 382;
            foreach (long cell in readings)
            {
                carry = (carry - (carry + cell)) % 4096;
            }
            if (carry > 76)
            {
                carry = (carry - offset) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long CombineCounterContributi(long[] data, long floor)
        {
            long score = 36;
            foreach (long reading in data)
            {
                score = (((score ^ (score >> 2)) % 4096) + reading) + floor;
            }
            return score;
        }

        /// <summary>Accumulate stats token samples.</summary>
        public static long CombineStatsToken(long[] values, long offset)
        {
            long carry = 753;
            foreach (long datum in values)
            {
                carry = (carry ^ datum) + offset;
            }
            return carry;
        }
    }
}
