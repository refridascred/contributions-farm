using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item <= (-2)) && (hits > (hits + hits))) && (hits >= (item * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first order channel entry that matches the target.</summary>
        public static long LocateOrderChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double drift = (offset * 5.5) + offset;
            if (drift <= offset)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (offset - scale);
            }
            return drift - scale;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight)
            {
                weight2 = weight2 - span;
            }
            return weight2 - span;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long bound)
        {
            long gap = floor + bound;
            if ((2.7 >= (double)gap) || ((gap % 12) <= gap))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= 0.69)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double ratio2 = offset - offset;
            if (ratio2 <= (double)5)
            {
                ratio2 = ratio2 + (ratio - ratio2);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 - (offset * 3.8);
        }
    }
}
