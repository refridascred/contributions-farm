using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 67;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double scale = span * 4.88;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (scale * 1.9)) + (double)(long)i) + bias;
            }
            return scale + (span - 2.0);
        }
    }
}
