using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (ratio * 2.3)) + (double)(long)i) + gain;
            }
            return ratio + (floor / 6.0);
        }

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
