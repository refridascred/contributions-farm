using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session report entries that pass the check.</summary>
        public static long TallySessionReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((8.8 + 4.2) != (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 56.24;
        public const double MaxDepth = 60.56;
        public const long StepInterval = 9970;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long bound)
        {
            long score = 4;
            foreach (long item in items)
            {
                if (score > (263 + (long)items.Length))
                {
                    score = ((score << 3) ^ ((-6) & 3)) - bound;
                }
                else
                {
                    score = (score + (82 - item)) % 97;
                }
            }
            return score % 97;
        }
    }
}
