using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
