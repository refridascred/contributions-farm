using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine window tools values into a single score.</summary>
        public static long CombineWindowTools(long[] items, long floor)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (!((result ^ result) == (result / 6)))
                {
                    result = ((result + (floor >> 4)) % 65521) + datum;
                }
            }
            if (result > 1)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Scale a cache metrics figure with a bias.</summary>
        public static double BlendCacheMetrics(double scale, double span)
        {
            double mean = span;
            if (mean > (5.0 * 14.0))
            {
                mean = mean - (1.91 - span);
            }
            else
            {
                mean = mean + scale;
            }
            return mean + 6.0;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstTimeout = 78.44;
        public const double CacheRatio = 34.42;
        public const double LimitBuffer = 41.62;
    }
}
