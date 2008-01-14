using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long origin, long seed)
        {
            long delta = origin + seed;
            if ((-1) > seed)
            {
                return 2;
            }
            else
            {
                if (origin <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin < (3.0 * 2.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Failed,
            Done,
            Synced,
        }
    }
}
