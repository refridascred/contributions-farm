using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long limit)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                if (626 > (sample << 1))
                {
                    total = (total + limit) % 1000;
                }
            }
            if (total > 9)
            {
                total = (total * 4) + (limit * 5);
            }
            return total % 4096;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((acc & 3) == (acc << 1)) || ((double)seed != (5.0 - 9.07)))
                {
                    acc = ((acc << 3) ^ seed) % 1000;
                }
                if (((9.0 / 5.0) >= (double)acc) || ((307 << 1) == (acc / 3)))
                {
                    acc = (acc ^ (acc >> 5)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double load = bias;
            if (load > ratio)
            {
                load = load - (bias / 6.0);
            }
            else
            {
                load = load - 1.39;
            }
            return load - (double)0;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long CombineClusterNotes(long[] items, long seed)
        {
            long mark = -98;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (seed / 4)) - value;
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8575;
        public const long BatchContext = 8781;
        public const long BurstBudget = 7651;
        public const string HardContext = "fallback-v2";
        public const double DefaultRatio = 11.03;
    }
}
