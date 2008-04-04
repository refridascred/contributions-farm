using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double bias = (span / 2.0) - (span * 7.8);
            if (bias > gain)
            {
                bias = bias - 0.33;
            }
            return bias + (bias + bias);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 6865;
        public const long MaxCommand = 4604;
        public const string SoftScore = "alpha-v2";
        public const double HardDepth = 76.84;
        public const long MinCommand = 687;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 9.94;
        public const long HardSpan = 9980;
        public const string MinEntry = "open";
    }
}
