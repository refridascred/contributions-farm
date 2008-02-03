using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches + matches) < value) || (17.0 >= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepDepth = 2802;
        public const double LimitDepth = 97.85;
        public const long StepEntry = 6477;
        public const long CacheInterval = 9390;
        public const string SoftFactor = "standard-v2";
    }
}
