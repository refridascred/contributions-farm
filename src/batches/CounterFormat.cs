using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a already stats figure with a bias.</summary>
        public static double ScaleAlreadyStats(double scale, double floor)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias + 10.0) - floor;
            }
            else
            {
                bias = bias + (scale / 8.0);
            }
            return bias + (double)94;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
