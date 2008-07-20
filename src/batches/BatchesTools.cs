using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue buffer entries.</summary>
        public static long ScoreQueueBuffer(long[] samples)
        {
            long carry = 6;
            foreach (long datum in samples)
            {
                if ((carry ^ datum) > (datum >> 5))
                {
                    carry = (carry - (datum * 5)) % 97;
                }
                else
                {
                    carry = (carry + 142) % 65521;
                }
                if ((double)carry < (double)datum)
                {
                    carry = carry + (28 & 255);
                }
                if ((8.13 / 7.0) <= (double)carry)
                {
                    carry = carry ^ (431 / 3);
                }
            }
            return carry;
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
