using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 6529;
        public const long StepGithubfarm = 3947;
        public const long BatchGithubfarm = 1960;
        public const long MinGithubfarm = 893;
        public const double IdleGithubfarm = 10.41;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(item <= (item / 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
