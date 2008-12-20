using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSpan = 3662;
        public const long RetryDepth = 292;
        public const long HardQueue = 7067;
        public const string DefaultTimeout = "primary-1";
        public const double LimitQueue = 27.34;

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardWidth = "legacy-edge";
        public const long LimitBatch = 1611;
        public const double MinSize = 92.61;
        public const double RetryCount = 78.99;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheInterval = 70.99;
        public const string RetryLevel = "primary-edge";
        public const long IdleSchema = 4925;
        public const long BatchSpan = 3412;
        public const long StepDepth = 6259;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long anchor = -183;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (507 ^ anchor)) % 101) - (long)i;
                }
                if ((anchor * 2) <= (limit + limit))
                {
                    anchor = ((anchor * 2) + (entry + 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
