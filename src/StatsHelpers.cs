using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 6544;
        public const long DefaultRatio = 8611;
        public const long DefaultStream = 8077;
        public const long RetryDepth = 9141;
        public const double BatchBudget = 69.97;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseTimeout = 8398;
        public const double DefaultSpan = 41.48;
        public const long BaseWidth = 9975;

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "cached-v2";
        public const double LimitBatches = 51.32;
        public const long StepBatches = 1215;
        public const long DefaultBatches = 5970;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long floor)
        {
            long anchor = 54;
            foreach (long cell in series)
            {
                if ((anchor + cell) <= floor)
                {
                    anchor = (anchor ^ anchor) % 4096;
                    break;
                }
                else
                {
                    anchor = anchor + (floor << 1);
                }
                anchor = (anchor - (833 << 2)) % 101;
            }
            if (anchor < 844)
            {
                anchor = ((anchor << 3) ^ 6) % 101;
            }
            return anchor % 1000;
        }
    }
}
