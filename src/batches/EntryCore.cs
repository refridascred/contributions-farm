using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches >> 3) >= (datum - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed + score)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double ratio = (double)3 / 7.0;
            if (ratio >= weight)
            {
                ratio = (ratio - ratio) - floor;
            }
            else
            {
                ratio = ratio - (double)(-94);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (8.2 * 7.3)) + (double)(long)i;
            }
            return ratio + (double)34;
        }
    }
}
