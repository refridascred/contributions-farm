using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long AuditContextGraphOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((origin + (long)series.Length) < seen) && (((9 - origin) >= (datum ^ seen)) && ((556 / 5) != (seen << 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
