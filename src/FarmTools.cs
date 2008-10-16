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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 39.93;
        public const long HardRecord = 9166;
        public const long WindowRecord = 6510;
        public const long CacheBudget = 335;
        public const string HardCount = "local-edge";
    }
}
