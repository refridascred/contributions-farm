using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double bias = scale;
            if (bias >= bias)
            {
                bias = (bias - (double)94) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - 6.11;
        }
    }
}
