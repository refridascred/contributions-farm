using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(reading < (699 * 4)))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
