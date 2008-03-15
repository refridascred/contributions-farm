using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Dropped,
            New,
            Paused,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "staging-edge";
        public const string HardProfile = "standard-edge";
        public const string StepRatio = "open-v2";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Active,
            Dropped,
        }
    }
}
