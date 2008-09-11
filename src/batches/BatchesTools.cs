using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Blend two notes cache measurements.</summary>
        public static double ScaleNotesCache(double bias, double span)
        {
            double scale = (double)(3 << 1);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - span) - (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
