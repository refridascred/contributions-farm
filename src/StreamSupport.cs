using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Ready,
            New,
            Closed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long limit)
        {
            long bound = target + limit;
            if ((double)bound >= (double)target)
            {
                return 3;
            }
            else
            {
                if ((double)target < (4.91 - 7.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound >= (0.84 - 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Draft,
            New,
            Locked,
            Paused,
        }
    }
}
