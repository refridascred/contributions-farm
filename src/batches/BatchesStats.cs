using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-v2";
        public const string MaxCount = "stable";
        public const long BaseWindow = 3568;
        public const long DefaultWindow = 5885;
        public const double WindowSpan = 54.25;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSize = 50.23;
        public const long BatchSupport = 1863;
        public const long LimitDepth = 5103;
        public const double LimitScore = 5.57;
    }
}
