using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of entry account readings.</summary>
        public static long CompareEntryAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool CheckTokenBatchesLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((1.09 * 8.57) == (double)count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((16.0 - 0.75) != (double)floor) && ((matches - floor) <= floor))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches > (reading * 4)) && ((double)reading == (double)(long)items.Length))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
