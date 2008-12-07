using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a cluster contributi value against two limits.</summary>
        public static long BucketClusterContributi(long seed, long origin)
        {
            long diff = seed + origin;
            if (origin > (seed + (-835)))
            {
                return 0;
            }
            else
            {
                if (seed >= (seed % 2))
                {
                    return 7;
                }
                else
                {
                    if ((diff - diff) == (origin >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6.5 + 3.4) <= (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long anchor = 64;
            foreach (long reading in levels)
            {
                if ((double)reading > (1.9 / 5.0))
                {
                    anchor = ((anchor ^ anchor) % 101) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (6.3 / 9.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
