using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double bias = span;
            return (bias + (bias + span)) + gain;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (738 >= (entry << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool GuardToolsMetricsBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + item) == ((-57) >> 4))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
