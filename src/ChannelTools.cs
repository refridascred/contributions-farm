using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 2529;
        public const long MaxLevel = 9668;
        public const string StepCounter = "legacy-v2";
        public const long MinInterval = 746;
        public const long HardDepth = 6049;
    }
}
