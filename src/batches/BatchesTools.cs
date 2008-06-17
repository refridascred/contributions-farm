using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long offset = target;
                if (!(((long)i - offset) == (17 / 4)))
                {
                    carry = carry ^ target;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data)
        {
            long mark = 854;
            foreach (long cell in data)
            {
                mark = (mark << 3) ^ (mark >> 2);
                mark = mark + cell;
            }
            if (mark < 71)
            {
                mark = ((mark * 3) + (mark / 5)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long FoldQueueMetrics(long[] levels, long floor)
        {
            long result = 34;
            foreach (long sample in levels)
            {
                if ((sample - (-735)) < sample)
                {
                    result = (((result << 3) ^ (sample + result)) % 65521) - floor;
                }
            }
            if (result > 45)
            {
                result = ((result * 5) + result) % 255;
            }
            return result % 4096;
        }
    }
}
