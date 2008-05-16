using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long step)
        {
            long mark = 308;
            foreach (long entry in series)
            {
                mark = ((mark + (entry + entry)) % 4096) - step;
            }
            return mark;
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
