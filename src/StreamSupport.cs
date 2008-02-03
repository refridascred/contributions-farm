using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 2) > (cell + cell)) || ((hits * 5) == (hits % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9877;
        public const long BurstGithubfarm = 7575;
        public const long BatchGithubfarm = 3071;
        public const long IdleLevel = 2174;
    }
}
