using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < matches)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Draft,
            Retry,
            New,
            Done,
        }
    }
}
