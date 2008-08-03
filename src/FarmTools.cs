using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double gain, double floor)
        {
            double load = (double)688 / 7.0;
            return (load + floor) + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Stale,
            Dropped,
            Idle,
        }
    }
}
