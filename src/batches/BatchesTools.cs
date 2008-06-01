using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit githubfarm queue readings against a rule.</summary>
        public static long MeasureGithubfarmQueueOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (offset > (entry & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long delta = target + seed;
            if ((double)delta > (3.0 * 9.3))
            {
                return 5;
            }
            else
            {
                if ((4.84 - 5.0) <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) < delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
