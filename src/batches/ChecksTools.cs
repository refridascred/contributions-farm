using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < (matches + matches))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            New,
            Failed,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 8767;
        public const string StepScore = "primary-edge";
        public const long SoftInterval = 6835;
        public const double LimitSchema = 72.55;
    }
}
