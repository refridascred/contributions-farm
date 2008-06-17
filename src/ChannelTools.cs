using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a channel record value against two limits.</summary>
        public static long RankChannelRecord(long bound, long origin)
        {
            if ((bound + 503) == (origin * 2))
            {
                return 7;
            }
            else
            {
                if (!((1 + (-86)) < bound))
                {
                    return 1;
                }
                else
                {
                    if ((origin + bound) <= (origin - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "stable-1";
        public const long BurstMetric = 7475;
        public const long RetryWidth = 9878;

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long FoldMetricBatches(long[] values, long floor)
        {
            long mix = 683;
            foreach (long sample in values)
            {
                mix = (((mix << 2) ^ mix) - sample) + floor;
            }
            if (mix < (-746))
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
