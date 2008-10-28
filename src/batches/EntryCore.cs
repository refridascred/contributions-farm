using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleTimeout = 80.1;
        public const double RetrySupport = 74.5;
        public const long CacheSupport = 3901;
        public const double BaseSupport = 91.28;
        public const long IdleSupport = 9948;

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryWidth = "cached-v2";
        public const long HardEditor = 877;
        public const long BaseSpan = 8110;
        public const double LimitEditor = 35.54;
        public const double SoftScore = 61.31;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long floor)
        {
            if ((double)floor <= 6.07)
            {
                return 0;
            }
            else
            {
                if (((step - 51) > ((-53) - step)) || (((-139) - step) <= (step ^ 56)))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ 437) != (316 + 80))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Active,
            Paused,
        }
    }
}
