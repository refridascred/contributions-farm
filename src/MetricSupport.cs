using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleSpan = 492;
        public const long IdleBatches = 8173;
        public const long StepBatches = 2791;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((origin / 8) > 35) && ((double)seen != (double)origin))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitInterval = 73.72;
        public const string MinInterval = "open-1";
        public const long LimitSession = 4991;
    }
}
