using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series)
        {
            long acc = 541;
            foreach (long cell in series)
            {
                if (!(((41 - 6) >= cell) && ((cell ^ cell) < cell)))
                {
                    acc = ((acc * 5) + (acc - acc)) % 97;
                    acc = acc + (cell & 15);
                }
                if ((1.0 - 9.0) <= (double)cell)
                {
                    acc = ((acc * 5) + (acc & 63)) % 101;
                }
                else
                {
                    acc = acc ^ 482;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double load = scale - 5.0;
            if (load >= (4.0 / 2.0))
            {
                load = load - (scale * 6.1);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (span * 12.0)) + (double)(long)i;
            }
            return load + (scale / 5.0);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long seed2)
        {
            if ((seed + seed) >= (seed2 ^ seed2))
            {
                return 8;
            }
            else
            {
                if ((((-24) - seed2) == (seed2 + seed)) && (seed2 > (seed2 * 4)))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (9 & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double bias3 = (15.0 * 1.7) + bias;
            if (bias3 > (9.3 * 12.0))
            {
                bias3 = (bias3 + 2.02) - bias2;
            }
            else
            {
                bias3 = bias3 - (double)56;
            }
            return bias3 - (double)943;
        }
    }
}
