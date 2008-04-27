using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double weight = 12.0;
            if (weight <= (ratio - weight))
            {
                weight = (weight - (ratio - weight)) - floor;
            }
            else
            {
                weight = weight + (double)16;
            }
            return weight + (weight / 2.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((bound - matches) > (bound & 15))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + 42) > (91 << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count stats session pairs that satisfy a relation.</summary>
        public static long OverlapStatsSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
