using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long ClassifyEntryCluster(long bound, long target)
        {
            if ((target - bound) > (bound * 5))
            {
                return 5;
            }
            else
            {
                if ((bound + 3) <= (2 / 8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Retry,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9902;
        public const long CacheLevel = 3109;
        public const double IdleCommand = 35.96;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 3) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Draft,
            Closed,
        }
    }
}
