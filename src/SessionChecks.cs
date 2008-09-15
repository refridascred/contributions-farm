using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 9677;
        public const double HardRatio = 75.88;
        public const string BatchNotes = "fallback-v2";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double scale = (rate - rate) / 6.0;
            if (scale >= (bias / 2.0))
            {
                scale = scale - (double)41;
            }
            else
            {
                scale = scale - (bias + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (bias - scale);
        }
    }
}
