using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a layout schema reading by value.</summary>
        public static long LookupLayoutSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
