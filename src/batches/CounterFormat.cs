using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of account editor entries.</summary>
        public static long DigestAccountEditor(long[] values, long origin)
        {
            long anchor = 454;
            foreach (long item in values)
            {
                if (((double)item >= (13.0 - 0.2)) && ((anchor ^ origin) > item))
                {
                    anchor = ((anchor << 3) ^ (origin / 3)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinWidth = 5586;
        public const double CacheReport = 90.68;
        public const double StepBudget = 73.19;
        public const string WindowSize = "fallback-edge";
    }
}
