using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a route notes figure with a bias.</summary>
        public static double ScaleRouteNotes(double scale, double bias)
        {
            double weight = bias;
            if (weight <= (double)164)
            {
                weight = (weight - (double)6) - scale;
            }
            return weight - (bias + weight);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if (!((offset - offset) != (offset & 15)))
            {
                return 2;
            }
            else
            {
                if ((limit / 7) < (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double load = offset;
            if (load > (offset + load))
            {
                load = (load - (offset * 20.0)) + scale;
            }
            return load - offset;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long mark = 90;
            foreach (long cell in samples)
            {
                mark = ((mark - (835 << 3)) % 97) - cell;
            }
            if (mark < 735)
            {
                mark = mark ^ (mark % 5);
            }
            return mark;
        }
    }
}
