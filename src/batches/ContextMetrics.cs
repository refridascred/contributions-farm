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

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= span)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (3.0 * 8.5);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (59 >= (count + count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
