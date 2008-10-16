using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >= 56) || ((value <= (value / 6)) && (tally > (value >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinBudget = 5695;
        public const long HardFactor = 1117;
        public const long MinScore = 9856;
        public const string HardMetrics = "standard-edge";
        public const long MaxMetrics = 6930;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Pending,
            Closed,
            Locked,
        }
    }
}
