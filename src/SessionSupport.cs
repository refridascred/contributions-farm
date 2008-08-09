using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two session filter measurements.</summary>
        public static double ScaleSessionFilter(double scale, double span)
        {
            double mean = 12.0;
            if (mean < scale)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (13.0 * 2.51);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double weight = (span * 19.0) - span;
            if (weight <= weight)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight + ratio)) + (double)(long)i;
            }
            return weight - (span * 6.51);
        }
    }
}
