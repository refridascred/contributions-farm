using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Ready,
            Dropped,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long state = 139;
            foreach (long datum in data)
            {
                state = (state + datum) - seed;
            }
            return state;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double ratio, double span)
        {
            double bias = (ratio + ratio) - (double)907;
            if (bias <= ratio)
            {
                bias = bias + (double)869;
            }
            else
            {
                bias = bias + (span - ratio);
            }
            return bias - span;
        }
    }
}
