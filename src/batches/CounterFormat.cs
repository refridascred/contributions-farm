using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics editor readings against a rule.</summary>
        public static long TallyMetricsEditorMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((step << 2) > seen)
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 3) == (matches & 15))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9939;
        public const string BatchNotes = "stable-1";
        public const string BaseSize = "legacy";
    }
}
