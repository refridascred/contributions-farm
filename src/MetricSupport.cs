using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            New,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Closed,
            Done,
            Idle,
            Stale,
        }
    }
}
