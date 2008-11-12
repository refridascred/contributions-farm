using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) + scale;
            }
            return rate + (rate - rate);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
