using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            New,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value >> 2) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
