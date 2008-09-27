using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3173;
        public const long WindowSchema = 1268;
        public const string CacheSchema = "fallback-1";
        public const long CacheBudget = 5865;
        public const long BurstScore = 1435;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (rate - offset);
            }
            return scale - offset;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long step, long origin)
        {
            long cur = step ^ origin;
            if (!((double)cur < 4.99))
            {
                return 4;
            }
            else
            {
                if ((origin ^ cur) < (step ^ step))
                {
                    return 5;
                }
                else
                {
                    if (!((origin - origin) == (origin / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin & 7) < (origin >> 5)) && ((797 + cur) < 538))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            New,
            Pending,
        }
    }
}
