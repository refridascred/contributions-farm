using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long AuditAccountClusterGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
