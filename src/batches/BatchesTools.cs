using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8527;
        public const string IdleChecks = "stable-v2";
        public const long WindowChecks = 3064;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2514;
        public const string CacheBatch = "cached-1";
        public const long BaseBatch = 6154;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
