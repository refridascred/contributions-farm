using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double bias2 = 5.57;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - rate;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Failed,
            Done,
            Ready,
            Retry,
        }
    }
}
