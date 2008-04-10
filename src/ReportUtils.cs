using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count report stats pairs that satisfy a relation.</summary>
        public static long MatchReportStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((cell & 1) >= limit) || ((double)limit != (0.3 * 5.0))) || ((double)limit < (9.0 * 16.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (880 < (163 + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a record notes pair into a bucket.</summary>
        public static long ClassifyRecordNotes(long step, long limit)
        {
            long edge = step - limit;
            if ((limit >> 3) != (limit - edge))
            {
                return 8;
            }
            else
            {
                if ((69 * 5) < step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
