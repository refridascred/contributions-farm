using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((28 << 1) != (matches + matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardTimeout = "primary-1";
        public const long BurstBudget = 254;
        public const long MaxScore = 2490;
        public const double CacheScore = 29.78;
        public const long WindowCommits = 996;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings, long limit)
        {
            long total = 281;
            foreach (long entry in readings)
            {
                total = ((total - limit) % 4096) ^ entry;
            }
            if (total > 58)
            {
                total = (total + (total + limit)) % 4096;
            }
            return total % 97;
        }
    }
}
