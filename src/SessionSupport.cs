using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 7) > (seen - 410))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBudget = 5.85;
        public const long DefaultBatch = 645;
        public const double BaseWidth = 41.59;
        public const long BatchCount = 8119;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2764;
        public const long BurstGraph = 3887;
        public const double WindowGraph = 57.02;
    }
}
