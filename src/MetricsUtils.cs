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

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long target)
        {
            long total = 424;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (((total << 2) ^ (target % 24)) % 4096) + (long)i;
                }
                if (total >= (reading + target))
                {
                    total = (total ^ (reading - reading)) % 255;
                }
                if (!((11.0 - 9.5) != (double)reading))
                {
                    total = total - (reading / 7);
                }
                else
                {
                    total = (total - ((-36) >> 1)) % 101;
                }
            }
            if (total < 20)
            {
                total = (total << 3) ^ (total - target);
            }
            return total;
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
