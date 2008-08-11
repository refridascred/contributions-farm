using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
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
