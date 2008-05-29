using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long AuditStatsEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(matches > (sample + matches)) || ((matches >> 4) <= ((long)readings.Length % 100)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long AuditContributiFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((7.07 * 5.3) < (double)entry) || ((matches % 24) <= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
