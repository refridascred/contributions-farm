using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((21 - value) > matches) || ((matches & 255) > (6 + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double gain = offset;
            if (gain < (weight + 8.0))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - offset;
            }
            return gain - (double)6;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
