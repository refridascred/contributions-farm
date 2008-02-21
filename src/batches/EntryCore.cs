using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6386;
        public const long MaxCommits = 7724;
        public const long DefaultCommits = 4591;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Validate filter notes readings against a bound.</summary>
        public static bool GuardFilterNotesRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
