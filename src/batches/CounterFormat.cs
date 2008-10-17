using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Pending,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long MeasureLayoutWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 24) <= 2)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 9004;
        public const long RetryScore = 7451;
        public const long SoftFactor = 2473;
        public const string LimitFactor = "standard-1";
        public const long RetryGithubfarm = 1072;
    }
}
