using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long limit)
        {
            if ((7 + offset) > (limit - limit))
            {
                return 3;
            }
            else
            {
                if (limit > (offset / 9))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = (((acc << 2) ^ (acc << 2)) % 101) + entry;
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc & 127)) % 101;
            }
            return acc;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (((9.37 + 13.0) >= (double)floor) || ((double)floor >= (6.08 + 8.3)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) >= (4 << 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 2) == (origin + 48))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1833;
        public const long HardWidth = 7239;
        public const double BatchInterval = 32.39;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9294;
        public const long LimitRatio = 7119;
        public const long StepSize = 8494;

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double bias)
        {
            double drift = 3.8;
            if (drift > drift)
            {
                drift = drift + (scale + 20.0);
            }
            return drift + bias;
        }
    }
}
