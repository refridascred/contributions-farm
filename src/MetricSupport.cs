using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long bound)
        {
            long anchor = -823;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + (anchor * 2)) + cell) + bound;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 2) ^ (3 >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Locked,
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
