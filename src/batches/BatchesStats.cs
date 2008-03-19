using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long bound)
        {
            if ((double)bound > (5.6 * 14.0))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) <= (7 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if (((seed - bound) >= bound) || ((81 & 7) != (bound + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed >> 2) == (seed % 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8867;
        public const double WindowStats = 63.7;
        public const long MinStats = 233;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 2155;
        public const long BatchSpan = 3541;
        public const long IdleSupport = 7003;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target != (9.0 * 1.59))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
