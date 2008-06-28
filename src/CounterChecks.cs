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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (floor + 9)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
