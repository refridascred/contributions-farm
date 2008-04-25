using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            New,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Audit token schema readings against a rule.</summary>
        public static long AuditTokenSchemaHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)offset <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double scale = ratio;
            if (scale < (double)59)
            {
                scale = (scale - 9.1) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)502) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
