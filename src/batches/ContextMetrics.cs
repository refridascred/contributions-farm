using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Pending,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double ratio2 = floor - (ratio - floor);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)0;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double load = bias;
            if (load <= (double)70)
            {
                load = (load + (load * 20.0)) + rate;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)3) - (double)(long)i;
            }
            return load - load;
        }
    }
}
