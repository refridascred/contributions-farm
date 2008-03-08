using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((6.9 > (double)count) && (count > (value << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter queue value from a seed.</summary>
        public static long IterateFilterQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ (582 / 5);
                carry = (carry ^ (carry - (long)i)) % 1000;
                if (!!((double)carry < (double)(-8)))
                {
                    carry = carry + (long)i;
                    carry = (carry << 3) ^ (offset ^ carry);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long seed, long offset)
        {
            if ((seed & 31) <= 33)
            {
                return 2;
            }
            else
            {
                if (seed < (offset * 3))
                {
                    return 5;
                }
                else
                {
                    if (seed <= (offset % 64))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
