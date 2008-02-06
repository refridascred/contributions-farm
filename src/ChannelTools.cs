using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long MeasureChecksSessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step & 7) != (6 * 4))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7095;
        public const long BaseRoute = 1115;
        public const long MinRatio = 5372;
        public const double HardRatio = 89.68;
        public const string MaxRoute = "legacy-1";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((91 + item) <= (item << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
