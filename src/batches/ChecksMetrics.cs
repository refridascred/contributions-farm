using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch notes readings against a bound.</summary>
        public static bool CheckBatchNotesLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryFactor = 3331;
        public const long StepSize = 5000;
        public const double CacheSpan = 52.42;

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "strict-edge";
        public const long SoftMetric = 9163;
        public const string BatchSize = "legacy-v2";
        public const long SoftFactor = 927;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 2151;
        public const long LimitLevel = 3126;
        public const long LimitWidth = 9563;
        public const long RetryBudget = 4644;

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepInterval = "strict";
        public const long LimitFactor = 7830;
        public const string DefaultFactor = "alpha-edge";
    }
}
