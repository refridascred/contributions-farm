using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine editor profile values into a single score.</summary>
        public static long TallyEditorProfile(long[] series)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                if (!((6.95 / 3.0) == (double)sample))
                {
                    anchor = (anchor + 68) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 7526;
        public const long WindowBatch = 4041;
        public const long DefaultBatch = 3935;
        public const double CacheCount = 24.44;
        public const long RetrySize = 4184;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)5 != (double)offset)
                {
                    mark = ((mark << 2) ^ (mark << 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "local";
        public const string StepMetrics = "alpha-v2";
        public const long WindowScore = 4030;
    }
}
