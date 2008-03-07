using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cluster command series from a seed.</summary>
        public static long SeriesClusterCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ ((long)i << 2)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value / 4) <= value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
