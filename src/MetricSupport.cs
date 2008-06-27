using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double scale = weight * 8.46;
            if (scale > (double)605)
            {
                scale = scale + (double)81;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (20.0 + weight);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
