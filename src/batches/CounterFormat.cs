using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitWidth = 10.51;
        public const double SoftBudget = 17.43;
        public const string MaxScore = "strict";
        public const double DefaultRatio = 1.7;

        /// <summary>Count the farm checks entries that pass the check.</summary>
        public static long AuditFarmChecksHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) > (sample / 8))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell + (-60)) > (floor >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
