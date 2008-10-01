using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9454;
        public const string BaseRatio = "local";
        public const double IdleBudget = 43.39;
        public const double IdleInterval = 41.26;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double mean = (double)(935 ^ 0);
            if (mean > (scale / 6.0))
            {
                mean = (mean + (scale / 9.0)) + span;
            }
            return mean - (0.8 + mean);
        }
    }
}
