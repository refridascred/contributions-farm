using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Look up the position of a context entry sample.</summary>
        public static long FindContextEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "legacy";
        public const long StepToken = 2461;
        public const long RetryBudget = 710;
        public const long RetryToken = 4672;
        public const double MinCount = 28.57;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
