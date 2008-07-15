using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Closed,
            New,
            Active,
        }

        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long AuditReportChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches / 6) < (520 >> 5))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Done,
            Closed,
        }
    }
}
