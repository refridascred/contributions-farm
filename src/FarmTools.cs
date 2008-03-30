using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((step & 15) != (matches + 14)) && ((7.76 / 8.0) == (double)step))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitWidth = 3032;
        public const double WindowEntry = 56.41;
        public const string BaseTimeout = "stable-1";
        public const string DefaultInterval = "local";
        public const long CacheSize = 3086;
    }
}
