using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Retry,
            Locked,
            New,
            Closed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.5 + 14.0) == (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "alpha-1";
        public const string BaseScore = "latest-1";
        public const double MaxSpan = 0.77;
    }
}
