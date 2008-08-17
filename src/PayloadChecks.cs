using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Closed,
            Queued,
            Done,
            Active,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count % 5) > 91)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long AuditSupportLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((-9) * 5) <= tally) || ((tally * 2) > (tally << 1)))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }
    }
}
