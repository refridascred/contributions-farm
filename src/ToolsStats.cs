using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double load = (bias / 7.0) / 4.0;
            if (load > (double)6)
            {
                load = (load - (5.3 / 4.0)) - weight;
            }
            return load + load;
        }

        /// <summary>Adjust a token route reading.</summary>
        public static double SmoothTokenRoute(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load + 16.0)) + (double)(long)i) + rate;
            }
            return load - (offset + load);
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8985;
        public const string SoftSpan = "latest-1";
        public const double LimitMetrics = 89.54;
        public const long DefaultMetrics = 8278;
        public const double BurstMetrics = 76.25;

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double scale = (double)(1 - (-423));
            if (scale < (double)0)
            {
                scale = (scale - (ratio - ratio)) - bias;
            }
            return scale - (ratio / 5.0);
        }
    }
}
