using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long ClassifyContextSession(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((origin < floor) || (floor <= (lane ^ lane)))
            {
                return 2;
            }
            else
            {
                if (!((floor ^ origin) < (39 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
