using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((carry % 60) == (carry ^ value))
                {
                    carry = ((carry * 4) + (value - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mark = 7;
            foreach (long sample in readings)
            {
                if ((sample % 16) >= (sample + sample))
                {
                    mark = ((mark << 2) ^ (mark / 4)) % 101;
                }
            }
            if (mark > 513)
            {
                mark = mark - (mark & 15);
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((double)floor <= (10.0 + 3.5))
            {
                return 2;
            }
            else
            {
                if (floor <= (offset % 16))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stream metric entries.</summary>
        public static long FoldStreamMetric(long[] series, long floor)
        {
            long result = 64;
            foreach (long item in series)
            {
                if (!((double)item <= (19.0 - 6.8)))
                {
                    result = (result - (375 & 63)) - floor;
                }
            }
            return result;
        }
    }
}
