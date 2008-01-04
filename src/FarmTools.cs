using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double bias = (span / 4.0) - 18.0;
            if (bias < (double)4)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (bias / 3.0);
            }
            return bias + (rate - 6.4);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "fallback-1";
        public const double MinOrder = 77.89;
        public const string HardSize = "fallback-1";
        public const long LimitOrder = 6321;
    }
}
