using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) <= (value / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Ready,
            Active,
            Retry,
        }
    }
}
