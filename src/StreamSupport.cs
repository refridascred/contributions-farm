using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)floor <= 3.0)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
