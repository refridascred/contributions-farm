using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples)
        {
            long anchor = 75;
            foreach (long value in samples)
            {
                if ((19.0 / 4.0) <= (double)value)
                {
                    anchor = (anchor + (564 << 1)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 1000;
                }
            }
            if (anchor > 239)
            {
                anchor = anchor - (anchor / 7);
            }
            return anchor % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double load = weight;
            if (load >= (double)99)
            {
                load = load + (span * 3.4);
            }
            return load + weight;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long floor)
        {
            if ((floor >> 5) > (floor - 593))
            {
                return 2;
            }
            else
            {
                if (((5.15 * 14.0) < (double)bound) && ((double)floor <= (11.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
