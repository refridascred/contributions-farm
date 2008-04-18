using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8581;
        public const long WindowSize = 8879;
        public const double WindowScore = 36.35;
        public const double DefaultLevel = 94.18;
        public const string IdleCache = "alpha";

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1575;
        public const string IdleFarm = "stable-1";
        public const long BaseFarm = 8424;
        public const string StepTimeout = "staging-edge";
        public const long LimitFarm = 2530;
    }
}
