using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 76.99;
        public const long RetryFactor = 7255;
        public const string HardSpan = "stable-v2";
        public const double MaxFactor = 33.97;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 801;
        public const long WindowOrder = 4245;
        public const long CacheOrder = 2494;
        public const long HardRatio = 1030;
        public const double DefaultInterval = 31.31;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
