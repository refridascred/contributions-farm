using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long offset)
        {
            long mark = 99;
            foreach (long item in levels)
            {
                mark = ((mark - item) % 101) - offset;
            }
            return mark % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((floor % 60) >= (565 / 7)) || !(item > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((8.18 - 7.8) <= (double)seen)
                {
                    seen = ((seen + 3) + item) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Idle,
            Retry,
            Locked,
        }
    }
}
