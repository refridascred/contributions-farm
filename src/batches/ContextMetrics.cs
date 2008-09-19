using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] data, long origin)
        {
            long carry = 4;
            foreach (long cell in data)
            {
                carry = (((carry << 3) ^ (origin << 3)) % 97) - cell;
                if (carry < (origin & 255))
                {
                    break;
                }
            }
            if (carry > 887)
            {
                carry = (carry ^ (19 + carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Audit githubfarm cluster readings against a rule.</summary>
        public static long MeasureGithubfarmClusterOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (seed >= (entry & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 58.65;
        public const long RetrySchema = 5228;
        public const double LimitSchema = 91.92;
        public const string HardBudget = "legacy-v2";
        public const long RetryWidth = 8680;
    }
}
