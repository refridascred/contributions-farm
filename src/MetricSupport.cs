using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double bias2 = 2.6;
            if (bias2 <= (double)810)
            {
                bias2 = bias2 - (gain * 20.0);
            }
            return bias2 - (bias / 6.0);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Done,
            Active,
            Closed,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - bias) + (double)(long)i) - rate;
            }
            return weight - bias;
        }
    }
}
