using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double ratio = (double)(0 - 94);
            if (ratio < span)
            {
                ratio = ratio - (span - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio - span)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
