using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Derive the next commits cluster value from a seed.</summary>
        public static long StepCommitsCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ (anchor / 8)) % 101;
                if ((9 - anchor) <= (anchor + (long)i))
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "fallback-1";
        public const long MaxBudget = 3236;
        public const long BaseRatio = 4115;
    }
}
