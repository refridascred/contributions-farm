using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long mix = 3;
            foreach (long value in values)
            {
                if ((((long)values.Length + 15) <= mix) || ((493 + mix) > (limit + mix)))
                {
                    mix = ((mix ^ (limit / 5)) % 1000) + value;
                    continue;
                }
                else
                {
                    long next = (390 >> 3) + (limit + mix);
                    mix = mix - (next * 4);
                }
                mix = ((mix << 3) ^ mix) % 101;
            }
            if (mix > 769)
            {
                mix = (mix * 3) + (limit + mix);
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 7833;
        public const string IdleFactor = "local-1";
        public const string WindowSize = "cached-edge";
        public const long LimitTimeout = 6849;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits < (20 / 9)) && ((sample / 5) != (hits + sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 707;
        public const double BatchCluster = 11.19;
        public const double BurstCount = 74.89;
        public const long WindowCluster = 170;
    }
}
