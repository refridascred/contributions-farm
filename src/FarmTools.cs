using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            if ((6.8 / 6.0) != (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)bound > (8.0 - 5.0)) && ((double)bound >= 9.11))
                {
                    return 1;
                }
                else
                {
                    if (((6.6 + 9.15) < (double)bound) || (seed > (seed & 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((58 * 2) > seed)
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
