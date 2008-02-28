using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a buffer report reading by value.</summary>
        public static long FindBufferReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema metric readings against a rule.</summary>
        public static long CountSchemaMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen == (4.0 * 1.1))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double scale = ratio;
            if (scale >= bias)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (1.9 - 0.53);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale - 10.0)) + (double)(long)i;
            }
            return scale + 5.54;
        }
    }
}
