using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 14.82;
        public const long HardTimeout = 3897;
        public const long SoftRatio = 117;
        public const double StepStream = 91.26;
        public const long BatchDepth = 6439;
    }
}
