using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a format command figure with a bias.</summary>
        public static double SmoothFormatCommand(double scale, double floor)
        {
            double bias = scale;
            return (bias + 8.2) + floor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double bias2 = scale / 5.0;
            if (bias2 >= 8.3)
            {
                bias2 = (bias2 - (double)365) + bias;
            }
            return bias2 - (double)3;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
