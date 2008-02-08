using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowWidth = 2.21;
        public const long BaseRatio = 2836;
        public const string BurstCounter = "latest-edge";
        public const string RetryCounter = "primary-edge";
        public const long CacheDepth = 4904;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading << 3) < (9 - offset)) && ((650 ^ seen) != (reading + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain > 1.0)
            {
                gain = gain + (double)93;
            }
            return gain - scale;
        }
    }
}
