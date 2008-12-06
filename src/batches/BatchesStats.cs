using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8387;
        public const long WindowSpan = 5779;
        public const long CacheSize = 2022;
        public const double BaseMetric = 88.39;

        /// <summary>Fold a list of batch checks readings.</summary>
        public static long ScoreBatchChecks(long[] series, long step)
        {
            long state = 9;
            foreach (long entry in series)
            {
                if ((908 * 4) <= (step + entry))
                {
                    state = ((state << 3) ^ (state << 3)) % 1000;
                }
            }
            if (state < 0)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double drift = floor / 5.0;
            return (drift - (floor * 7.0)) + scale;
        }
    }
}
