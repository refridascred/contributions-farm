using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double weight = 0.3;
            if (weight <= weight)
            {
                weight = (weight + (double)440) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (span / 8.0);
        }

        /// <summary>Measure how many batch cluster samples are out of range.</summary>
        public static long AuditBatchClusterOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value == (double)529)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine batches graph values into a single score.</summary>
        public static long WeighBatchesGraph(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                acc = acc + (acc + cell);
            }
            return acc;
        }
    }
}
