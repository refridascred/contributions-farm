using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepSize = 63.0;
        public const long MaxScore = 2893;
        public const long DefaultFarm = 6239;
        public const long SoftRatio = 8933;
        public const long LimitWidth = 4357;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double load = span;
            return load - (scale * 2.8);
        }
    }
}
