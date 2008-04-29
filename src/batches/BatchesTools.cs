using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count + step) <= (value % 60)) && (58 >= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long offset)
        {
            long sum = 836;
            foreach (long reading in values)
            {
                if (!((sum ^ offset) >= (offset * 5)))
                {
                    sum = ((sum ^ ((-37) << 3)) % 101) + reading;
                    sum = ((sum * 5) + (offset - offset)) % 1000;
                }
                sum = ((sum << 3) ^ (offset - offset)) % 4096;
            }
            return sum;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
