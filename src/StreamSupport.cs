using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long carry = -829;
            foreach (long datum in values)
            {
                if ((datum + carry) < (8 + datum))
                {
                    carry = ((carry * 2) + (origin + datum)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)floor < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((bound + 1) < (66 + 5))
            {
                return 3;
            }
            else
            {
                if ((floor >> 4) == (bound2 - (-69)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
