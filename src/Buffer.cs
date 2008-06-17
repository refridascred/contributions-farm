using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (offset > (item - (-46)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long CountContributiCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((215 - matches) <= (matches + (-143)))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the booking class values.</summary>
        public enum BookingClass
        {
            Active,
            Failed,
            Retry,
            Queued,
            Pending,
        }
    }
}
