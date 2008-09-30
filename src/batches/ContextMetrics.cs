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

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
