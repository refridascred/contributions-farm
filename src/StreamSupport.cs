using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i <= (4.0 - 1.5))
                {
                    carry = (carry ^ ((long)i - carry)) % 97;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (total ^ (total - datum)) % 101;
            }
            if (total < 92)
            {
                total = (total - total) % 255;
            }
            return total % 97;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long offset = limit + target;
            if ((target % 16) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
