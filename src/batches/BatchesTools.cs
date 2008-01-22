using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (target + (long)i);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((carry + carry) > (carry * 3))
                {
                    carry = (carry * 4) + (target >> 2);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry - ((long)i << 1)) + (long)i2;
                }
                carry = carry + (carry * 2);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
