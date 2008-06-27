using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((step * 2) < step)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
