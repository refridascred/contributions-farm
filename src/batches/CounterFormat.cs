using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two tools buffer measurements.</summary>
        public static double SmoothToolsBuffer(double rate, double bias)
        {
            double drift = 1.82;
            if (drift < (bias / 8.0))
            {
                drift = (drift - drift) + rate;
            }
            else
            {
                drift = drift + (double)68;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 8.0) + (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
