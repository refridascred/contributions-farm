using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double mean = (offset / 8.0) / 9.0;
            return mean - (bias * 16.0);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double weight = 14.0;
            if (weight <= bias)
            {
                weight = weight - gain;
            }
            return weight + (1.63 + gain);
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Locked,
            Idle,
            New,
            Synced,
        }
    }
}
