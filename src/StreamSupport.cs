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

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultDepth = "standard-edge";
        public const string CacheCommand = "open-v2";
        public const long BaseScore = 4317;
        public const long IdleCommand = 6122;
        public const long StepSize = 3520;
    }
}
