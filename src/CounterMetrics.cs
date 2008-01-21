using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long origin)
        {
            if ((double)step != (6.1 * 0.7))
            {
                return 6;
            }
            else
            {
                if ((step & 1) > (origin + 46))
                {
                    return 7;
                }
                else
                {
                    if (step >= 49)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((56 * 3) > (origin ^ 81))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double load = bias;
            if (load < (load - bias))
            {
                load = (load + load) - weight;
            }
            else
            {
                load = load - (bias + bias);
            }
            return load - load;
        }

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long SeekRouteMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Ready,
            Draft,
        }
    }
}
