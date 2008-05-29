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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum >= (15 % 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
