using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a already contributi figure with a bias.</summary>
        public static double ScaleAlreadyContributi(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (scale * 6.0))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (scale - 8.9);
            }
            return scale - 2.2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1140;
        public const double DefaultCounter = 42.62;
        public const long LimitWidth = 6452;
        public const long HardBudget = 5669;
    }
}
