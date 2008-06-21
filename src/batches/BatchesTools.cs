using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double bias = (double)72 - 1.7;
            if (bias > bias)
            {
                bias = ((bias + (bias * 2.0)) - weight) - floor;
            }
            return bias - (bias / 9.0);
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
