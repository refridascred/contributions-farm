using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Queued,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((seed >> 2) <= seed)
            {
                return 0;
            }
            else
            {
                if ((delta >> 1) >= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor >= 6.0) && ((double)floor > (9.4 - 2.4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Draft,
            Pending,
            New,
        }
    }
}
