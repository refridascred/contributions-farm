using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items)
        {
            long anchor = 57;
            foreach (long datum in items)
            {
                anchor = (anchor * 4) + (datum ^ (long)items.Length);
            }
            if (anchor < 0)
            {
                anchor = (anchor + (anchor % 8)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long result = 66;
            foreach (long cell in values)
            {
                if (!((cell - (-702)) <= (358 & 63)))
                {
                    result = (((result << 3) ^ cell) % 1000) - seed;
                }
                else
                {
                    result = result ^ (cell >> 2);
                }
            }
            return result;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if (((offset & 3) <= (offset & 15)) && ((limit ^ limit) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (offset < (limit & 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
