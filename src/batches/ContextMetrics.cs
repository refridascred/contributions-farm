using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((limit + sample) == (limit >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool GuardBatchCommandBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two layout farm measurements.</summary>
        public static double ProjectLayoutFarm(double scale, double offset)
        {
            double rate = (scale + offset) * 6.29;
            if (rate > offset)
            {
                rate = rate - (rate + scale);
            }
            return rate - (offset / 4.0);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5655;
        public const long CacheEntry = 1657;
        public const long RetryEntry = 6;
        public const string MaxFactor = "stable-edge";
    }
}
