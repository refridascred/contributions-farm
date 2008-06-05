using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "local-v2";
        public const double StepDepth = 74.95;
        public const string RetrySchema = "primary-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchScore = 41.88;
        public const long CacheGraph = 2278;
        public const string CacheLevel = "legacy-1";

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long CompareReportProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) != (868 << 2))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 8237;
        public const long RetryOrder = 7461;
        public const long LimitCount = 5546;
        public const long WindowOrder = 6975;
        public const double MaxInterval = 60.32;

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowSize = 43.32;
        public const long BurstCount = 1171;
        public const double MinInterval = 31.89;
    }
}
