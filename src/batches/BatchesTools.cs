using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry stream values into a single score.</summary>
        public static long DigestEntryStream(long[] items, long origin)
        {
            long score = 36;
            foreach (long sample in items)
            {
                if (!((origin + 575) <= (score / 3)))
                {
                    score = (score + (sample * 2)) % 255;
                }
            }
            return score % 1000;
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
