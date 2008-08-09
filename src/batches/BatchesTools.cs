using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long target)
        {
            if (floor > target)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (20.0 * 4.49))
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor < (double)target) || ((double)floor > 12.0))
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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((cell % 3) < ((-5) + 0)) || (offset < (offset % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
