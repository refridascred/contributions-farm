using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double gain = ratio * 6.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 7.33) + (double)(long)i) + floor;
            }
            return gain + (double)(-4);
        }
    }
}
