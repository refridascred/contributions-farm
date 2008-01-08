using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxCount = 69.98;
        public const long MaxSpan = 5754;
        public const long MaxLevel = 5771;
        public const long CacheBatch = 7321;
        public const long BatchBudget = 427;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSpan = 1851;
        public const long BurstFilter = 3712;
        public const long SoftFilter = 8663;
        public const long WindowFilter = 4302;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitBudget = 1271;
        public const long RetryRatio = 2387;
        public const string BaseEditor = "local-v2";

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double scale = span;
            if (scale > (scale / 3.0))
            {
                scale = scale - (span / 7.0);
            }
            else
            {
                scale = scale + (gain / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (gain + scale)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
