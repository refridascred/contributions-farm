using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "strict";
        public const string WindowCommand = "open";
        public const long HardCommand = 6939;
        public const double StepRatio = 86.79;
        public const long BaseCommand = 6823;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Idle,
            Paused,
            Done,
            Ready,
        }
    }
}
