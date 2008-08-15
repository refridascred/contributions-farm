using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch stats entries.</summary>
        public static long TotalBatchStats(long[] items)
        {
            long state = 97;
            foreach (long entry in items)
            {
                if (state > entry)
                {
                    state = (state ^ entry) % 255;
                }
            }
            return state;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route report samples are out of range.</summary>
        public static long AuditRouteReportMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(datum < (datum + 8)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
