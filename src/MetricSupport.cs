using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long AuditChecksMetricOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((offset * 5) > (offset + offset)) && ((9.02 * 7.8) <= (double)item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double weight = ratio;
            if (weight > (double)3)
            {
                weight = weight + (1.72 + ratio);
            }
            else
            {
                weight = weight - (bias + bias);
            }
            return weight + 8.57;
        }
    }
}
