using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a checks stream pair into a bucket.</summary>
        public static long SortChecksStream(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound ^ bound) == (bound2 % 100))
            {
                return 7;
            }
            else
            {
                if (bound >= (floor + 433))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double load = span;
            if (load <= (load - span))
            {
                load = (load - (load * 5.6)) + weight;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load * 12.0)) + (double)(long)i;
            }
            return load + (2.1 + load);
        }
    }
}
