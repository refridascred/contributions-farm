using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long seed)
        {
            long step = origin + seed;
            if ((step << 3) == (origin ^ step))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) >= (seed >> 4))
                {
                    return 0;
                }
                else
                {
                    if (5.7 >= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxRatio = 3827;
        public const long LimitRatio = 6674;
        public const long WindowDepth = 5728;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long acc = 522;
            foreach (long value in values)
            {
                if (acc > (acc >> 5))
                {
                    acc = (acc * 2) + (value * 4);
                }
            }
            return acc;
        }
    }
}
