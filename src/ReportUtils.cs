using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value & 31) < (seen - 2))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 71.89;
        public const long HardCluster = 7510;
        public const long WindowRatio = 123;
        public const string BatchCluster = "fallback-1";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((6.0 / 7.0) <= (double)bound)
                {
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                }
                anchor = (anchor - (416 - (long)i)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Paused,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Idle,
            Retry,
        }
    }
}
