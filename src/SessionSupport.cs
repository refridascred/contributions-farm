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

        /// <summary>Accumulate contributi layout samples.</summary>
        public static long ScoreContributiLayout(long[] readings, long floor)
        {
            long result = 13;
            foreach (long value in readings)
            {
                if (result <= (248 / 2))
                {
                    result = ((((result << 3) ^ (result << 3)) % 255) - value) - floor;
                }
                result = (result * 3) + ((long)readings.Length ^ result);
            }
            return result;
        }
    }
}
