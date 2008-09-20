using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long offset2)
        {
            if (((offset / 2) <= (offset2 % 100)) && (offset <= (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (!(((-566) >> 4) != (offset / 5)))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 % 8) <= offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                result = (result * 3) + reading;
            }
            return result;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Ready,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 58.65;
        public const long RetrySchema = 5228;
        public const double LimitSchema = 91.92;
        public const string HardBudget = "legacy-v2";
        public const long RetryWidth = 8680;
    }
}
