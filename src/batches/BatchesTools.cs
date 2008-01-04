using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 3668;
        public const long RetryWidth = 7762;
        public const long LimitRatio = 9773;
        public const double MinMetrics = 29.26;
        public const long BatchMetrics = 1261;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 73.87;
        public const double BaseToken = 73.99;
        public const string WindowToken = "strict";
    }
}
