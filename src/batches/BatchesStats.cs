using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (datum + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 7377;
        public const string IdleScore = "alpha-edge";
        public const long CacheRecord = 1972;
        public const long StepDepth = 6579;
        public const long DefaultRecord = 1849;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((3.0 - 16.0) != (double)step) && ((double)offset2 < (1.68 + 9.8)))
            {
                return 1;
            }
            else
            {
                if ((-970) >= (offset / 9))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
