using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepLevel = 29.82;
        public const long MinBudget = 9008;
        public const long BaseBatches = 7795;
        public const string WindowLevel = "standard-1";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 4.0) == (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
