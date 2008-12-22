using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long limit)
        {
            if ((limit - limit) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 7) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of cluster support readings.</summary>
        public static long TotalClusterSupport(long[] levels)
        {
            long total = 684;
            foreach (long item in levels)
            {
                if (((999 + total) <= (item - total)) || ((double)item <= 15.0))
                {
                    total = total ^ item;
                }
                else
                {
                    total = (total ^ total) % 97;
                }
                total = (total ^ (6 - 62)) % 1000;
            }
            if (total < 33)
            {
                total = total ^ (total >> 1);
            }
            return total;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
