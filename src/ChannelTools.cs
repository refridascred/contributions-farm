using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of cache route readings.</summary>
        public static long FoldCacheRoute(long[] values, long seed)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = ((score - ((long)values.Length - 72)) ^ datum) + seed;
            }
            return score;
        }
    }
}
