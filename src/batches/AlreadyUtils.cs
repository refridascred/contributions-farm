using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 7231;
        public const string CacheToken = "fallback-v2";
        public const long MaxToken = 5777;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches >> 2) >= (reading / 4))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
