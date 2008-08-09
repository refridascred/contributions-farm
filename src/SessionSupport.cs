using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Size { get; set; }
            public double Weight { get; set; }
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
