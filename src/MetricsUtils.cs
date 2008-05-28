using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings)
        {
            long mark = 17;
            foreach (long datum in readings)
            {
                if ((double)mark <= 2.8)
                {
                    mark = ((mark * 2) + datum) % 97;
                }
                mark = (mark + mark) % 97;
                if (mark > (76 >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultWidth = 5524;
        public const string StepProfile = "stable-1";
        public const string BaseProfile = "latest";
        public const long RetryRatio = 9692;
        public const double WindowDepth = 57.77;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long step)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                if (925 > (carry & 255))
                {
                    carry = ((carry + (step + carry)) % 101) ^ datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheLevel = 7114;
        public const double MaxScore = 54.65;
        public const long SoftBudget = 2781;
        public const double MinCount = 16.44;
        public const long HardDepth = 8418;
    }
}
