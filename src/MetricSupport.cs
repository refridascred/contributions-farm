using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long limit)
        {
            long gap = seed + limit;
            if ((limit % 64) < (seed - gap))
            {
                return 8;
            }
            else
            {
                if (!((6.99 * 16.0) > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((limit - gap) < 0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (78 & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 36.16;
        public const long MaxSize = 1822;
        public const long IdleWidth = 2456;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long step)
        {
            long mark = -4;
            foreach (long reading in samples)
            {
                if ((step + reading) <= step)
                {
                    mark = (mark ^ (34 % 7)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
