using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stream cluster samples.</summary>
        public static long TotalStreamCluster(long[] readings, long limit)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc - (limit * 4)) ^ item;
            }
            if (acc > 5)
            {
                acc = acc ^ limit;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double load = (floor * 10.0) / 3.0;
            return load + rate;
        }
    }
}
