using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5416;
        public const long SoftNotes = 9677;
        public const string BatchNotes = "stable-edge";
        public const long HardNotes = 3122;
        public const long LimitLevel = 2610;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheSize = 510;
        public const string BurstRatio = "latest";
        public const long BaseRatio = 3770;
        public const long StepEntry = 6214;
        public const long WindowWidth = 8076;
    }
}
