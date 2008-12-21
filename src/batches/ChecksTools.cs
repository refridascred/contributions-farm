using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchBudget = 9748;
        public const long BurstBudget = 3379;
        public const long SoftWidth = 6556;
        public const double MaxLevel = 4.88;
        public const long MaxScore = 7767;

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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
