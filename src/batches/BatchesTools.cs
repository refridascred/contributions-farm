using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (6.2 + span)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
