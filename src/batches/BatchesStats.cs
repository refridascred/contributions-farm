using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool CheckMetricsSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            long lane = seed - step;
            if (((-357) - step) != (lane * 5))
            {
                return 7;
            }
            else
            {
                if ((double)seed == (9.1 - 2.5))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double weight = span;
            if (weight < rate)
            {
                weight = weight - (rate - rate);
            }
            else
            {
                weight = weight - rate;
            }
            return weight + rate;
        }
    }
}
