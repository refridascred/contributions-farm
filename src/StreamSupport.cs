using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream record readings against a rule.</summary>
        public static long AuditStreamRecordOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)count >= (9.0 * 2.0)) && ((603 + cell) < (count & 31)))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
