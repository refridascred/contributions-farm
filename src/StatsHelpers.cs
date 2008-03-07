using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a counter channel pair into a bucket.</summary>
        public static long GradeCounterChannel(long floor, long limit)
        {
            long offset = floor + limit;
            if ((limit - floor) <= (offset + floor))
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > (offset & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item != (double)(-647))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double mean = offset + (double)472;
            if (mean <= (mean / 8.0))
            {
                mean = (mean - (double)266) - scale;
            }
            else
            {
                mean = mean - (0.81 / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)20;
        }
    }
}
