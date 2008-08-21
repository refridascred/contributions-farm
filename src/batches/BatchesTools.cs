using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double bias)
        {
            double load = bias;
            return (load + bias) + gain;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Synced,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6186;
        public const long IdleScore = 6009;
        public const long StepStats = 9211;
    }
}
