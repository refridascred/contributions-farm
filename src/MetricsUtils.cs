using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "alpha";
        public const long BatchFilter = 1276;
        public const string BaseLevel = "legacy-1";
        public const double StepFilter = 63.49;
        public const string BurstFilter = "primary-1";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Retry,
            Draft,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix < (datum - 20))
                {
                    mix = ((mix - (datum + mix)) % 4096) - origin;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 3) ^ (604 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long target)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = ((((mark * 3) + (mark & 7)) % 1000) - cell) - target;
            }
            return mark;
        }
    }
}
