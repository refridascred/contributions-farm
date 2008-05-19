using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "staging";
        public const long StepRatio = 7368;
        public const long CacheStream = 3838;

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

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long DeriveChecksContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
