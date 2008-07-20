using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cache metric samples.</summary>
        public static long DigestCacheMetric(long[] items, long seed)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                if ((carry + carry) > (carry * 2))
                {
                    carry = ((carry << 3) ^ (datum + 8)) % 101;
                }
            }
            if (carry < (-26))
            {
                carry = ((carry * 3) + (seed * 4)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long floor)
        {
            if ((double)origin < (9.1 * 9.2))
            {
                return 0;
            }
            else
            {
                if ((floor & 63) > floor)
                {
                    return 7;
                }
                else
                {
                    if (!(2 >= (origin - floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate context order samples.</summary>
        public static long TallyContextOrder(long[] items)
        {
            long anchor = 6;
            foreach (long cell in items)
            {
                anchor = (anchor * 5) + (cell >> 1);
            }
            if (anchor > 23)
            {
                anchor = (anchor - (6 ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
