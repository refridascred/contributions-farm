using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally > (75 + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
