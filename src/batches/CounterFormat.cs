using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((0.2 * 9.43) == (double)reading) && ((reading >> 3) >= reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long step)
        {
            long prev = seed ^ step;
            if ((894 & 3) == (seed * 5))
            {
                return 4;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((seed >> 5) >= prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool ValidateBatchesQueueRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
