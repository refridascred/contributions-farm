using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSize = 7090;
        public const long BatchWidth = 1652;
        public const double WindowRatio = 23.5;
        public const long StepFactor = 7097;
        public const long LimitWidth = 5996;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long TallyFormatOrder(long[] items, long origin)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ 70) ^ item;
                anchor = ((anchor * 2) + (24 ^ origin)) % 101;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (54 - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepWidth = 83.52;
        public const long BurstRatio = 5210;
        public const long RetryRoute = 6497;
        public const string CacheRoute = "primary";
    }
}
