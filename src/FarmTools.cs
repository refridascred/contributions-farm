using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long AuditWindowQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (0.15 > (double)seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.65 - 15.0) >= (double)origin)
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
