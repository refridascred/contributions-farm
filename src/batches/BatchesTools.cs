using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long BucketWindowCache(long limit, long floor)
        {
            long next = limit - floor;
            if (floor < (floor << 3))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit / 4))
                {
                    return 8;
                }
                else
                {
                    if (((next + floor) > limit) || (limit > (limit % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long target)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                if ((anchor & 255) > anchor)
                {
                    anchor = (anchor << 2) ^ (target % 100);
                }
                if ((457 >> 2) < (anchor / 2))
                {
                    anchor = ((anchor << 2) ^ (reading * 5)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + target) % 97;
                }
            }
            if (anchor > 980)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) % 1000;
            }
            return anchor % 97;
        }
    }
}
