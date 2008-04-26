using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double scale = (double)(11 << 1);
            if (scale >= scale)
            {
                scale = scale - (scale - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain - offset)) + (double)(long)i;
            }
            return scale + (offset * 9.0);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long target)
        {
            if ((double)target <= (5.05 + 13.0))
            {
                return 1;
            }
            else
            {
                if ((bound / 5) > (bound << 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound % 24) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (18.0 >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter batches entries that pass the check.</summary>
        public static long CountCounterBatchesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((196 << 3) > (entry + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
