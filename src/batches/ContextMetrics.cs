using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long AuditReportMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((double)seen != (4.0 * 2.0)))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + tally) <= (tally << 1))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double load = scale;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (double)(-43)) - (double)(long)i) + floor;
            }
            return load + (scale * 7.06);
        }
    }
}
