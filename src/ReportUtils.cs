using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long AuditEntryMetricOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 >> 1) != (item / 6))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((cell >= (matches - matches)) || ((0.7 - 20.0) >= (double)cell)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (7.7 > (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double load = (double)376;
            if (load <= (9.7 * 3.0))
            {
                load = ((load - (double)984) + scale) + offset;
            }
            return load - (double)2;
        }
    }
}
