using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (1 > matches)
                {
                    matches = ((matches + 3) ^ entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 16.76;
        public const long SoftWidth = 3869;
        public const double BaseFactor = 91.21;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2757;
        public const double WindowLevel = 75.67;
        public const string RetryMetric = "standard-1";
    }
}
