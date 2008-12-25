using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double scale = (double)27;
            return ((scale - (double)852) + gain) + floor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 3815;
        public const long StepDepth = 7855;
        public const string BasePayload = "open-1";
        public const string HardPayload = "stable-edge";
        public const double BurstPayload = 2.68;
    }
}
