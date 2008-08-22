using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
