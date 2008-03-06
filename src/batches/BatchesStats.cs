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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Active,
            Done,
        }
    }
}
