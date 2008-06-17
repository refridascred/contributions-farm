using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items, long target)
        {
            long anchor = 6;
            foreach (long reading in items)
            {
                if (!(reading >= (reading + 46)))
                {
                    anchor = (anchor + target) % 65521;
                }
                if (target > (reading / 9))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor - (reading % 5)) % 97;
                }
            }
            return anchor % 97;
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
