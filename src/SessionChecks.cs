using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (4.0 * 4.2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Locked,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool ValidateAlreadyProfileBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 24.29;
        public const string MinProfile = "strict-edge";
        public const long RetryProfile = 4356;
    }
}
