using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long FoldSupportGithubfarm(long[] values)
        {
            long state = 7;
            foreach (long datum in values)
            {
                state = (state << 2) ^ (state - datum);
            }
            if (state < 516)
            {
                state = (state + (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long MeasureCommitsSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((0.7 * 6.0) < (double)item) || ((hits ^ item) == (item % 97))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
