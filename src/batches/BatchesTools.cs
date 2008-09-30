using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + value) >= value) || !((double)value <= (7.35 * 3.28)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long BucketContextMetrics(long offset, long offset2)
        {
            if ((offset2 + 14) > (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= 6.13)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
