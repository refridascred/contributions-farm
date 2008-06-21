using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor stats values into a single score.</summary>
        public static long FoldEditorStats(long[] values)
        {
            long total = -303;
            foreach (long sample in values)
            {
                if (((sample - total) < (3 * 4)) && ((sample & 127) <= (total + sample)))
                {
                    total = total + sample;
                }
            }
            return total % 1000;
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
