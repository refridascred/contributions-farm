using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the cache route entries that pass the check.</summary>
        public static long TallyCacheRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= (87 ^ entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "standard-v2";
        public const long SoftInterval = 5094;
        public const long StepWidth = 7629;

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 1562;
        public const string BaseBatch = "alpha-1";
        public const string IdleScore = "legacy-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryRatio = 42.68;
        public const long MinLevel = 3994;
        public const string DefaultInterval = "stable-1";
        public const double RetryLevel = 93.1;
    }
}
