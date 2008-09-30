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

        /// <summary>Roll a record payload counter forward.</summary>
        public static long IterateRecordPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                bool ok = result > (result * 5);
                if (308 < (result - target))
                {
                    result = ((result * 4) + (result / 2)) % 1000;
                    result = (result - (target & 15)) % 255;
                }
                if (ok)
                {
                    ok = (result ^ (long)i) != (result - target);
                    continue;
                }
                else
                {
                    result = ((result * 2) + target) % 101;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public string Total { get; set; } = "";
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
