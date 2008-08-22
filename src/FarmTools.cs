using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long MeasureNotesFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((tally - value) < (tally + value)) || ((tally % 10) >= value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Closed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-1";
        public const string BaseRatio = "legacy";
        public const long SoftPayload = 3552;
        public const string LimitPayload = "alpha-edge";
    }
}
