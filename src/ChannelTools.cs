using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Retry,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long floor)
        {
            long delta = bound ^ floor;
            if (!((floor - floor) >= 924))
            {
                return 4;
            }
            else
            {
                if (((double)delta == (6.3 - 3.27)) && ((bound / 4) != (floor / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 3) != (floor + bound))
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
    }
}
