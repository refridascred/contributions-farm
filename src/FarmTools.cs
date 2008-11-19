using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepScore = "legacy-v2";
        public const long SoftScore = 1146;
        public const double DefaultSpan = 14.26;
        public const long MaxStream = 6356;
        public const string MinStream = "alpha";

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool VerifyWindowMetricRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
