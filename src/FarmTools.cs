using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Paused,
            Queued,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((0 + seen) <= (-8)) || ((seen ^ datum) >= (7 - 0))) || (((seen ^ seen) < seen) || ((12.0 - 2.04) >= (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
