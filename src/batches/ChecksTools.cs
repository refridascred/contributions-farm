using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            New,
            Paused,
            Ready,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Closed,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5329;
        public const long BaseSize = 2653;
        public const long DefaultCount = 9874;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
