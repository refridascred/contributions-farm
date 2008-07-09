using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 0.8;
            if (mean <= floor)
            {
                mean = (mean + (double)5) + ratio;
            }
            return mean + floor;
        }
    }
}
