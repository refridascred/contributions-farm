using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double drift = span - span;
            if (drift < (double)2)
            {
                drift = drift + (bias * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (double)233;
        }

        /// <summary>Scale a notes token figure with a bias.</summary>
        public static double BlendNotesToken(double rate, double bias)
        {
            double load = (double)((-481) + 281);
            return ((load - (double)(-7)) + rate) + bias;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
