using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain2 / 8.0)) - bias;
            }
            return gain2 + (9.0 * 19.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 8824;
        public const double RetryCache = 58.63;
        public const long WindowDepth = 693;
        public const long WindowTimeout = 9207;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Retry,
            Stale,
            New,
        }
    }
}
