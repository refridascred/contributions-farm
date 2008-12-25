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

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchInterval = 5234;
        public const long LimitSupport = 6372;
        public const string IdleSupport = "open-1";
    }
}
