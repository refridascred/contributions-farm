using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 5885;
        public const long LimitTimeout = 673;
        public const long WindowScore = 7123;

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = 6.39;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + weight;
            }
            return gain - (floor / 8.0);
        }
    }
}
