using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Queued,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxScore = 1451;
        public const long BaseBudget = 5792;
        public const long HardDepth = 5233;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
