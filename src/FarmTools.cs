using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + sample) <= (2 + tally))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxBudget = 243;
        public const long LimitFactor = 3015;
        public const string WindowScore = "staging-1";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value > (0.07 * 0.2))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
