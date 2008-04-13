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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7918;
        public const long HardWidth = 9608;
        public const string CacheRecord = "primary-edge";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((1 - entry) >= matches)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
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
