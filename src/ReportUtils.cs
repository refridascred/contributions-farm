using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate account format readings against a bound.</summary>
        public static bool VerifyAccountFormatBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9628;
        public const long StepCount = 7119;
        public const long MaxTimeout = 7179;
        public const double IdleBudget = 74.26;
        public const string LimitFilter = "standard";

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7918;
        public const long HardWidth = 9608;
        public const string CacheRecord = "primary-edge";

        /// <summary>Count the window githubfarm entries that pass the check.</summary>
        public static long MeasureWindowGithubfarmMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) <= (hits - hits))
                {
                    hits = ((hits + 2) + datum) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long bound)
        {
            long mark = 16;
            foreach (long sample in readings)
            {
                if ((sample >> 3) < (734 / 6))
                {
                    mark = (mark + (bound * 4)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
