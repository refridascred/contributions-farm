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

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (origin * 3)) % 101) + (long)i2;
                }
                acc = acc - (long)i;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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
