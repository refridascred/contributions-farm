using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((838 << 1) <= (entry - (long)items.Length))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long carry = 35;
            foreach (long cell in levels)
            {
                if ((16.0 - 17.0) <= (double)cell)
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = (carry ^ 245) % 4096;
                }
            }
            return carry;
        }
    }
}
