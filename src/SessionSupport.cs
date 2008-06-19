using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long target)
        {
            long mark = 541;
            foreach (long reading in samples)
            {
                if ((target - reading) >= (mark * 3))
                {
                    mark = mark - (mark * 5);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Measure how many account stream samples are out of range.</summary>
        public static long MeasureAccountStreamHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count >= (6.0 * 1.82))
                {
                    count = ((count + 1) - value) + target;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1141;
        public const long StepWidth = 5567;
        public const long BurstScore = 2678;
        public const long DefaultSize = 1272;
        public const long BurstCluster = 4556;
    }
}
