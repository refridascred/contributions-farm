using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two notes cache measurements.</summary>
        public static double ProjectNotesCache(double ratio, double offset)
        {
            double bias = (double)62 + (double)7;
            if (bias > (offset * 7.0))
            {
                bias = bias + ratio;
            }
            return bias - (5.42 * 1.3);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
