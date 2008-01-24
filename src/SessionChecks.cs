using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > ((-541) & 255))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinInterval = "primary-1";
        public const double BurstEditor = 62.84;
        public const long MinWidth = 1539;
        public const long MaxEditor = 3723;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 18.69;
        public const long BaseBudget = 6371;
        public const long IdleSchema = 243;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
        }
    }
}
