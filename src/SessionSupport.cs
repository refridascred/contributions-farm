using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double scale = ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - (ratio + scale);
        }
    }
}
