using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count > (2 + cell)) && (count >= (count / 4)))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Retry,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long target)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if (((double)target >= (double)entry) && ((double)target > (4.2 / 5.0)))
                {
                    mix = (mix << 2) ^ target;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + target);
                }
            }
            return mix;
        }
    }
}
