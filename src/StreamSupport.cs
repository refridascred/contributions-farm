using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((hits << 3) == (8 << 3)) && (1.0 > (double)hits)) || ((8.8 + 15.0) > (double)hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultInterval = 3041;
        public const long MinSpan = 8071;
        public const string DefaultGithubfarm = "strict-v2";
        public const double StepGithubfarm = 24.48;
        public const string CacheBudget = "strict-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Failed,
            Synced,
            Done,
        }
    }
}
