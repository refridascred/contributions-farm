using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool ValidateChecksRecordRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinBudget = 3636;
        public const double BurstWindow = 13.94;
        public const long BatchScore = 1270;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
