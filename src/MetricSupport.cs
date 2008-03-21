using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits < (reading + bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if (!((double)limit < 6.9))
            {
                return 6;
            }
            else
            {
                if ((floor >= (limit & 255)) && ((floor + limit) < limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
