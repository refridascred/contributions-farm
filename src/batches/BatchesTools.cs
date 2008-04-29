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

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values, long seed)
        {
            long sum = 66;
            foreach (long cell in values)
            {
                if (((double)seed <= (double)(-24)) || (seed >= (long)values.Length))
                {
                    sum = sum ^ (cell - cell);
                }
            }
            if (sum > 9)
            {
                sum = ((sum << 2) ^ (seed << 3)) % 65521;
            }
            return sum % 4096;
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
