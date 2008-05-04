using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of profile cluster readings.</summary>
        public static long TallyProfileCluster(long[] values)
        {
            long score = 8;
            foreach (long sample in values)
            {
                if (!((sample & 63) != (score + score)))
                {
                    score = (score - (580 >> 5)) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleInterval = 4488;
        public const double BaseSpan = 65.86;
        public const double CacheRatio = 43.54;
        public const string MaxTimeout = "stable";
        public const string BaseFactor = "cached-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3219;
        public const long WindowRatio = 3055;
        public const long IdleCommits = 6005;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
