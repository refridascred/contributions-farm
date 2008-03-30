using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchScore = 5532;
        public const long HardAlready = 7486;
        public const long MaxCount = 9179;
        public const long StepScore = 4557;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= (count + value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 2.1)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 18.53;
        public const string IdleBatch = "alpha-v2";
        public const long RetryFactor = 6471;
        public const double WindowDepth = 43.97;
        public const string SoftLevel = "alpha-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftScore = 4100;
        public const string LimitBuffer = "cached-edge";
        public const long DefaultSize = 9885;
        public const string StepFactor = "open";
    }
}
