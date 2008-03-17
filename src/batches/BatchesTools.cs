using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Done,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 7102;
        public const long MaxDepth = 8851;
        public const long WindowCommits = 8482;
        public const long MinCommits = 486;
        public const long BaseCommits = 3486;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }
    }
}
