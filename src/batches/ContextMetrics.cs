using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 4663;
        public const long SoftTimeout = 5205;
        public const long WindowContext = 7263;
        public const long BurstContext = 6547;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6852;
        public const long CacheFormat = 4034;
        public const long StepRatio = 4965;
        public const long DefaultCount = 4964;
        public const long MaxTimeout = 5063;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 1221;
        public const string BaseSpan = "alpha-1";
        public const long CacheScore = 2924;
        public const long HardWidth = 9483;
        public const long BurstNotes = 3589;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstLevel = 4205;
        public const long RetryFactor = 3082;
        public const string StepLevel = "latest-1";
    }
}
