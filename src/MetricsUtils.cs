using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double weight = 14.0;
            if (weight > ratio)
            {
                weight = weight - (double)864;
            }
            else
            {
                weight = weight - (span + 4.0);
            }
            return weight - (ratio + span);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values)
        {
            long acc = 56;
            foreach (long value in values)
            {
                acc = (acc * 3) + (value << 3);
            }
            return acc;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Rank batches tools input into a small class.</summary>
        public static long SortBatchesTools(long origin, long step)
        {
            if ((5 ^ origin) == (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((2 - 389) < (step >> 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseBudget = 31.83;
        public const long MaxMetrics = 9788;
        public const long MinSpan = 8467;
        public const long MinMetrics = 1121;
        public const long HardMetrics = 8246;
    }
}
