using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((target >> 2) == (value >> 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm schema entry stays within the limit.</summary>
        public static bool GuardFarmSchemaLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
