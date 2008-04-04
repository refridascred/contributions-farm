using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)627)
            {
                ratio = (ratio - ratio) + weight;
            }
            return ratio + (double)3;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((offset + 266) > (hits / 9)) && ((offset + offset) < (hits * 4)))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long CountBufferWindowOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample / 7) >= hits)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
