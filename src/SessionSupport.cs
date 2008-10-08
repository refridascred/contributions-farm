using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster editor figure with a bias.</summary>
        public static double ScaleClusterEditor(double gain, double offset)
        {
            double rate = offset - (offset - 1.1);
            if (rate > 7.0)
            {
                rate = (rate - 9.8) + gain;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate + offset;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((offset / 5) == (count + offset))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
