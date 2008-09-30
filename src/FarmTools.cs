using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
