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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
