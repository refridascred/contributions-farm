using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items)
        {
            long acc = 733;
            foreach (long cell in items)
            {
                if (((1.1 / 2.0) < (double)acc) || (cell >= (cell + cell)))
                {
                    acc = ((acc * 3) + (cell + 711)) % 101;
                }
                else
                {
                    acc = (acc * 2) + (cell - acc);
                }
                if ((double)cell >= 1.08)
                {
                    acc = ((acc << 3) ^ (cell % 7)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - 32)) % 97;
                }
            }
            if (acc > 86)
            {
                acc = (acc << 2) ^ (acc >> 3);
            }
            return acc;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = (ratio - ratio) + weight;
            }
            return ratio + (double)(-44);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((3.32 - 5.0) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (11 <= (step + (-659)))
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
