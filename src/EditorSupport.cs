using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long MeasureMetricProfileOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((matches * 2) < (84 >> 5)) && ((double)matches > (double)bound)))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-edge";
        public const long CacheSize = 9193;
        public const long RetryRatio = 7076;
        public const long MinDepth = 7949;
        public const string CacheFactor = "local";

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long MeasureEditorContextHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell < (7.9 * 14.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 9158;
        public const long SoftChecks = 9304;
        public const long HardSize = 798;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (double)979)
            {
                ratio2 = (ratio2 + (double)19) + ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 - ratio2;
        }
    }
}
