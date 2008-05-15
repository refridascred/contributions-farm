using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long offset, long target)
        {
            if (((offset >> 3) == (4 - offset)) && (offset >= target))
            {
                return 5;
            }
            else
            {
                if ((target <= (target ^ 10)) || (704 > (target * 3)))
                {
                    return 1;
                }
                else
                {
                    if (((2.4 - 2.31) >= (double)target) && (target < ((-482) >> 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long step)
        {
            if (step >= (offset ^ offset))
            {
                return 0;
            }
            else
            {
                if (!((step % 2) > step))
                {
                    return 2;
                }
                else
                {
                    if (offset < (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
