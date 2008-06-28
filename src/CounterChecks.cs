using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepRatio = 5379;
        public const long DefaultCluster = 775;
        public const string CacheInterval = "fallback-v2";
        public const string BatchSize = "fallback";
        public const string CacheRatio = "primary";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 53.72;
        public const double LimitInterval = 31.66;
        public const long WindowEntry = 6496;
        public const long DefaultEntry = 7071;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (75 >= (seen / 5))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (seed < (entry / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long offset)
        {
            if (256 < (offset - step))
            {
                return 7;
            }
            else
            {
                if ((step - step) <= (offset - step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
