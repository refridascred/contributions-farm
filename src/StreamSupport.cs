using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 8596;
        public const double MinFactor = 38.1;
        public const string BaseDepth = "fallback-edge";
    }
}
