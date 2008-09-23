using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7 <= (tally % 7))
                {
                    tally = ((tally + 3) - item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 1608;
        public const long BatchCount = 3647;
        public const long IdleGithubfarm = 6508;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Done,
            Active,
            Paused,
        }
    }
}
