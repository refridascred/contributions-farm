using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
