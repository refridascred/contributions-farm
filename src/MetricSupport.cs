using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout farm entries that pass the check.</summary>
        public static long TallyLayoutFarmGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - floor) >= (count / 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Grade a counter cache value against two limits.</summary>
        public static long SortCounterCache(long target, long seed)
        {
            if (((seed - target) < ((-3) >> 5)) || ((0.08 * 0.96) == (double)seed))
            {
                return 2;
            }
            else
            {
                if ((5.4 + 6.5) <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
