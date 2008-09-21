using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of cluster profile readings.</summary>
        public static long TotalClusterProfile(long[] samples)
        {
            long sum = -84;
            foreach (long sample in samples)
            {
                if ((double)sum != (9.7 + 4.3))
                {
                    sum = (sum - sample) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            if (sum < 274)
            {
                sum = (sum * 3) + (715 ^ sum);
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits >= (datum ^ hits)) || (hits > (hits % 5)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
