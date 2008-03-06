using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double scale = (double)(325 + 2);
            return ((scale - (double)0) + ratio) + offset;
        }

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
