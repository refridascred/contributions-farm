using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseDepth = 7.64;
        public const long IdleSupport = 8598;
        public const long MinCount = 8763;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Ready,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((2.2 - 18.0) >= (double)offset) && ((double)reading < (double)offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long CountGithubfarmWindowMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((step % 97) <= (value - value)) && ((value >> 1) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
