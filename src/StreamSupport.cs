using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long step)
        {
            long sum = 270;
            foreach (long value in items)
            {
                if (step > (value + value))
                {
                    sum = sum + 33;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "primary-v2";
        public const long IdleGithubfarm = 4226;
        public const string MinGithubfarm = "cached";
        public const long WindowBudget = 4130;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Dropped,
            New,
            Stale,
            Queued,
        }
    }
}
