using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 2) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
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
