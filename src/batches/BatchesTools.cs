using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)floor > (4.0 + 0.99))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long total = 646;
            foreach (long entry in items)
            {
                total = (total ^ (limit - total)) + entry;
            }
            return total;
        }
    }
}
