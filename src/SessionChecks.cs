using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Synced,
            Closed,
            Dropped,
            Pending,
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
