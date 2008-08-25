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

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double rate = (double)51 - (bias * 5.2);
            if (rate <= ratio)
            {
                rate = rate + (1.03 * 7.06);
            }
            return rate - (3.9 / 7.0);
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
