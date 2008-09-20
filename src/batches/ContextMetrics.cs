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

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] values)
        {
            long sum = 386;
            foreach (long item in values)
            {
                long diff = item;
                sum = sum + (diff - sum);
                if ((double)sum < 6.0)
                {
                    sum = (sum + 93) % 101;
                }
            }
            if (sum > (-183))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
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
