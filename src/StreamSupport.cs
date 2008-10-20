using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MinFactor = 76.56;
        public const double BatchSchema = 44.82;
        public const string CacheLevel = "fallback-1";
        public const long DefaultSchema = 2716;
        public const string LimitSchema = "legacy-v2";

        /// <summary>Validate cache queue readings against a bound.</summary>
        public static bool CheckCacheQueueLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double weight2 = (weight - span) / 8.0;
            if (weight2 < (weight2 - weight))
            {
                weight2 = weight2 + (weight / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (weight2 / 6.0)) + (double)(long)i;
            }
            return weight2 - (weight2 - weight);
        }
    }
}
