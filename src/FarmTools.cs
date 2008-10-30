using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long target)
        {
            long lane = bound + target;
            if (!((lane + bound) < (target + 186)))
            {
                return 7;
            }
            else
            {
                if ((target - lane) >= lane)
                {
                    return 3;
                }
                else
                {
                    if (!(lane <= (lane >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Draft,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Synced,
            Idle,
        }
    }
}
