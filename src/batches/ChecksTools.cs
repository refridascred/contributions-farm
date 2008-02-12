using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit >> 1) <= 33)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "cached-v2";
        public const string WindowCache = "cached-edge";
        public const long IdleSpan = 3620;
        public const double SoftCache = 27.77;
    }
}
