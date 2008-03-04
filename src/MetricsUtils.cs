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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((double)floor < 17.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 4281;
        public const long MaxScore = 4797;
        public const string LimitLevel = "standard-edge";
        public const string StepInterval = "strict";
        public const string BatchFarm = "standard-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long sum = 895;
            foreach (long item in levels)
            {
                if ((item + sum) < (258 + item))
                {
                    sum = (sum - (sum << 1)) % 1000;
                }
            }
            return sum;
        }
    }
}
