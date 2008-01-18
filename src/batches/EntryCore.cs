using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long BucketCommitsEditor(long offset, long bound)
        {
            if (((offset * 4) < (offset >> 3)) || ((3 * 2) <= (bound - offset)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 1) < (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound + offset) != (offset & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!!((step - 604) != (step / 5)))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((4 + tally) != (datum + 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            if (!(floor > (floor + floor)))
            {
                return 3;
            }
            else
            {
                if (((9.5 * 7.4) > (double)floor) || (floor >= (422 ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
