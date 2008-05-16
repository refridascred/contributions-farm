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

        /// <summary>Audit session batch readings against a rule.</summary>
        public static long CountSessionBatchMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length == (hits + hits)) || (origin <= (origin + 157)))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
