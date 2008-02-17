using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next queue route value.</summary>
        public static double SmoothQueueRoute(double gain, double floor)
        {
            double bias = (double)(13 % 7);
            if (bias >= bias)
            {
                bias = bias - (bias + bias);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias - (double)232;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
