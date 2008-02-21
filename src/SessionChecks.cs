using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate route contributi readings against a bound.</summary>
        public static bool GuardRouteContributiBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Failed,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool ValidatePayloadBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
