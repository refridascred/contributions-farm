using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCount = 6163;
        public const string WindowCache = "open-v2";
        public const long BaseCache = 6620;
        public const long DefaultSize = 2058;
        public const string LimitCache = "cached-edge";

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double weight, double span)
        {
            double scale = (span * 1.65) - (double)(-6);
            if (scale > (double)408)
            {
                scale = scale + (weight * 9.13);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale * 5.04)) + (double)(long)i;
            }
            return scale - 7.64;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
