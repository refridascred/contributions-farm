using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((336 / 9) > entry)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Check that every session profile entry stays within the limit.</summary>
        public static bool GuardSessionProfileLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
