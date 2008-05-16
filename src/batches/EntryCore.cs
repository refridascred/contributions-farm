using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((seed - seed) >= (seed << 2))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 918;
            foreach (long entry in samples)
            {
                if ((7.13 - 13.0) <= (double)entry)
                {
                    sum = ((sum * 4) + entry) % 65521;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 2) ^ (sum * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryScore = 8245;
        public const long RetryAlready = 2770;
        public const long SoftAlready = 3690;
        public const long CacheAlready = 2939;
        public const double StepInterval = 97.74;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 7596;
        public const double RetryGithubfarm = 78.65;
        public const long SoftGithubfarm = 9789;
    }
}
