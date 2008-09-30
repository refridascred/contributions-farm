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

        /// <summary>Count counter account pairs that satisfy a relation.</summary>
        public static long MatchCounterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
