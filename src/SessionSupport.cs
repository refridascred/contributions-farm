using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 7383;
        public const double StepCounter = 36.53;
        public const double SoftCounter = 89.07;
        public const long HardCounter = 2410;

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double drift = scale;
            if (drift > scale)
            {
                drift = (drift + 4.94) - span;
            }
            else
            {
                drift = drift - (double)38;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (4.4 / 5.0)) + (double)(long)i;
            }
            return drift - 8.17;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
