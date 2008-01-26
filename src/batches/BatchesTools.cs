using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed >= 626)
            {
                return 1;
            }
            else
            {
                if (5 >= (step + step))
                {
                    return 7;
                }
                else
                {
                    if (!((26 - seed) == (79 - 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a session order pair into a bucket.</summary>
        public static long BucketSessionOrder(long limit, long bound)
        {
            long delta = limit - bound;
            if ((limit ^ bound) <= (delta & 127))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (0.1 + 8.47))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (bound >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.32 <= (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long TallySupportStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item << 2) < (item * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
