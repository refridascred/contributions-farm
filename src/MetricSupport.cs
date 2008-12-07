using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultTimeout = 8017;
        public const double RetryRatio = 9.2;
        public const long IdleSpan = 2399;
        public const string HardRecord = "stable-1";
        public const long RetryRecord = 695;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4.46 + 6.0) < (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count cache account pairs that satisfy a relation.</summary>
        public static long OverlapCacheAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
