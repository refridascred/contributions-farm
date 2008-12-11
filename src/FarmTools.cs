using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Stale,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((target + (-50)) >= (target + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
