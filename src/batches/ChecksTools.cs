using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultBudget = 3141;
        public const string DefaultSize = "alpha-v2";
        public const long RetryGithubfarm = 131;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 6333;
        public const double MinCount = 77.87;
        public const double SoftSpan = 51.55;
        public const long StepWidth = 6391;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((double)tally >= 5.67) && ((bound / 3) > (bound & 63)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
