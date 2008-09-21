using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = ((acc - 48) % 255) - reading;
            }
            if (acc < 11)
            {
                acc = (acc + (5 + acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "stable-v2";
        public const long RetryAlready = 6059;
        public const long StepAlready = 6114;
        public const long BaseLevel = 6791;
        public const double HardSpan = 61.85;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Queued,
            Done,
            Active,
        }
    }
}
