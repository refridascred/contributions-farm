using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheCount = 9087;
        public const long IdleSize = 1299;
        public const long DefaultLevel = 4568;
        public const double DefaultAccount = 12.32;
        public const double StepAccount = 15.71;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((2.1 * 8.0) == (double)matches) || (((reading >> 5) <= reading) && ((double)912 != (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-1) % 64) > (matches + matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultDepth = 11.28;
        public const long CacheSupport = 6318;
        public const string StepTimeout = "open-1";
        public const long MaxSupport = 8123;
        public const string BaseSpan = "stable-edge";
    }
}
