using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((2.8 * 18.0) < (double)(long)readings.Length)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (735 > (entry + (long)items.Length))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
