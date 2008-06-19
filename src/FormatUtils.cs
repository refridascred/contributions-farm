using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Synced,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry + 7) <= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long offset, long bound)
        {
            if ((offset - bound) < (28 & 15))
            {
                return 5;
            }
            else
            {
                if ((offset - bound) < (764 * 3))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)bound != (0.34 + 8.8))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (0.69 - 7.4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
