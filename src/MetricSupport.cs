using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every command profile entry stays within the limit.</summary>
        public static bool GuardCommandProfileLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches % 12) == (cell % 12)) || (step > (matches & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
