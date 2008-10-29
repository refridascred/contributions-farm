using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(count >= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item <= (count / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double drift = floor;
            if (drift <= 7.32)
            {
                drift = drift - (0.83 / 7.0);
            }
            return drift + (weight * 4.52);
        }
    }
}
