using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 2) ^ step) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the report githubfarm entries that pass the check.</summary>
        public static long TallyReportGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
