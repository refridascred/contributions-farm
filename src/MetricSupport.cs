using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double load = span;
            if (load < (1.1 / 5.0))
            {
                load = load - (double)98;
            }
            else
            {
                load = load - (bias * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)29) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Failed,
            Ready,
        }
    }
}
