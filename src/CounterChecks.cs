using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first editor window entry that matches the target.</summary>
        public static long FindEditorWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics farm readings.</summary>
        public static long TotalMetricsFarm(long[] readings)
        {
            long mark = 53;
            foreach (long reading in readings)
            {
                if (((reading + mark) >= (reading >> 2)) || ((675 >> 2) <= (reading - mark)))
                {
                    mark = (mark ^ 576) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long TallySessionFormatMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)origin <= (6.6 + 0.72))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the commits stream entries that pass the check.</summary>
        public static long AuditCommitsStreamOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((seed << 3) > count)
                {
                    count = (count + 1) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Queued,
            Done,
        }
    }
}
