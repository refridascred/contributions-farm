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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long bound)
        {
            if (bound >= (bound + seed))
            {
                return 6;
            }
            else
            {
                if ((21 << 3) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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
