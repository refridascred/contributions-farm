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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

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
