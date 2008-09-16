using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 44.44;
        public const double BurstRoute = 61.81;
        public const long CacheRoute = 4577;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            long offset = target + bound;
            if ((double)offset >= (6.18 * 1.21))
            {
                return 0;
            }
            else
            {
                if ((target << 1) != (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if (target <= (77 - 188))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every order already entry stays within the limit.</summary>
        public static bool ValidateOrderAlreadyLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long score = 51;
            foreach (long item in levels)
            {
                score = (((score * 4) + (score + score)) % 101) - item;
            }
            return score % 65521;
        }
    }
}
