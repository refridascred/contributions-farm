using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 35.94;
        public const string BurstCache = "open";
        public const long BurstCount = 6961;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double ratio = (floor * 1.93) - (double)980;
            return (ratio - (double)406) + rate;
        }

        /// <summary>Count the batches route entries that pass the check.</summary>
        public static long MeasureBatchesRouteGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)bound > 11.0))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 6609;
        public const long DefaultContributi = 8587;
        public const long CacheScore = 4637;
    }
}
